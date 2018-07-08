using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using PPYC.Model;
using PPYC.ServerInteract;
using PPYC.Utils;
using Timer = System.Windows.Forms.Timer;

namespace PPYC
{
    public partial class FormMain : Form
    {
        private ApiLoginInfo m_LoginInfo;
        private IList<ApiReservedDate> m_ReserDates;
        private IList<Button> m_ReserDateBtns;
        private int m_CurBtnIndex;
        private Timer timer;
        #region FormInit 登录，获取教练信息

        public FormMain()
        {
            InitializeComponent();
        }

        private void SetControlFont(Control control)
        {
            if (control is System.Windows.Forms.Label)
            {
                control.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            }
            else if (! (control is Form))
            {
                control.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            }

            foreach (Control child in control.Controls)
            {
                SetControlFont(child);
            }
        }

        private void LoadReserDateBtns()
        {
            m_ReserDateBtns = new List<Button>();
            m_ReserDateBtns.Add(btnDay1);
            m_ReserDateBtns.Add(btnDay2);
            m_ReserDateBtns.Add(btnDay3);
            m_ReserDateBtns.Add(btnDay4);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetControlFont(this);
            LoadReserDateBtns();
            if (string.IsNullOrEmpty(LoginParameter.LoginPhoneNumber)) return;

            txtPhoneNumber.Text = LoginParameter.LoginPhoneNumber;
            txtPassword.Text = LoginParameter.LoginPassword;
            btnLogIn.PerformClick();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            var now = DateTime.Now.ToString("HH:mm:ss:fff");
            if (string.CompareOrdinal(now, "12:48:59") >= 0) // "17:59:59"
            {
                timer.Stop();
                txtCountDown.Text = "执行预约中...";
                btnReserve.PerformClick();
            }

            txtCountDown.Text = now;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DoLogIn();
            GetTeacherID();
            GetReserveDate();
            this.Cursor = Cursors.Default;
        }

        private GetApiCodeResult GetNewApiCode(bool isPopupError = true)
        {
            var apiCodeResult = GetApiCode.DoJob();
            if (!apiCodeResult.IsSuccessed)
            {
                if (isPopupError)
                {
                    MessageBox.Show("获取 ApiCode 失败！");
                }
                return null;
            }
            return apiCodeResult;
        }

        private void DoLogIn()
        {
            LoginParameter.LoginPhoneNumber = txtPhoneNumber.Text;
            LoginParameter.LoginPassword = txtPassword.Text;

            var apiCodeResult = GetNewApiCode();
            if(apiCodeResult == null) return;

            var loginInfo = Login.DoLogin(apiCodeResult.Data);
            if (!loginInfo.IsSuccessed)
            {
                MessageBox.Show(loginInfo.Message, "登录失败");
                return;
            }

            m_LoginInfo = loginInfo.Data[0];
            txtUserName.Text = m_LoginInfo.UserName;
        }

        private void GetTeacherID()
        {
            var apiCodeResult = GetNewApiCode();
            if (apiCodeResult == null) return;
            var teacherResult = GetTeacherInfo.Get(apiCodeResult.Data, m_LoginInfo);
            if (!teacherResult.IsSuccessed)
            {
                MessageBox.Show(teacherResult.Message, "获取教练信息失败");
                return;
            }

            m_LoginInfo.TeachNo = teacherResult.Data.TeachNo;
            txtTeacherID.Text = m_LoginInfo.TeachNo;
        }

        private void GetReserveDate()
        {
            var apiCodeResult = GetNewApiCode();
            if (apiCodeResult == null) return;
            var reserveDate = GetReservedDateList.Get(apiCodeResult.Data, m_LoginInfo);
            if (!reserveDate.IsSuccessed)
            {
                MessageBox.Show(reserveDate.Message, "获取可预约日期失败");
                return;
            }

            m_ReserDates = reserveDate.Data;
            // 目前只能提前四天
            for (int i = 0; i < 4; i++)
            {
                m_ReserDateBtns[i].Text = m_ReserDates[i].WeekName + Environment.NewLine + m_ReserDates[i].ReservedTime;
            }
            m_ReserDateBtns[3].PerformClick();
        }
        #endregion

        #region 获取某天的预约信息列表

        private void btnDay_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Button tar = sender as Button;
            string reserveDate = null;
            for (int i = 0; i < m_ReserDateBtns.Count; i++)
            {
                var btn = m_ReserDateBtns[i];
                if (btn == tar)
                {
                    btn.BackColor = Color.SpringGreen;
                    reserveDate = m_ReserDates[i].ReservedDate;
                    m_CurBtnIndex = i;
                }
                else
                {
                    btn.BackColor = SystemColors.Control;
                }
            }

            grdReserveInfo.DataSource = null;
            GetReserveInfoForDay(reserveDate);
            this.Cursor = Cursors.Default;
        }

        private void GetReserveInfoForDay(string date)
        {
            List<ApiReserveTime> reserveTimeList = new List<ApiReserveTime>();
            for (int i = 1; i < 4; i++)
            {
                var apiCode = GetNewApiCode();
                if (apiCode == null) return;
                var reserveResult = GetReservedTimeList.Get(apiCode.Data, m_LoginInfo, date, i);
                if (reserveResult.IsSuccessed)
                {
                    reserveTimeList.AddRange(reserveResult.Data);
                }
            }
            AddReserveInfoToTable(reserveTimeList);
        }

        private void AddReserveInfoToTable(IList<ApiReserveTime> infos)
        {
            var table = infos.ToDataTable();
            DataView dv = table.DefaultView;
            dv.Sort = "IsValid desc, StartTime asc";
            table = dv.ToTable();
            grdReserveInfo.DataSource = table;
            ResourceManagerUtil.ChangeDatagridViewTitle(grdReserveInfo);
        }

        private void grdReserveInfo_DataSourceChanged(object sender, EventArgs e)
        {
            if(grdReserveInfo.DataSource == null) return;
            if (!grdReserveInfo.Columns.Contains("IsSelect"))
            {
                DataGridViewCheckBoxColumn colSelect = new DataGridViewCheckBoxColumn();
                colSelect.Name = "IsSelect";
                colSelect.HeaderText = ResourceManagerUtil.GetString(colSelect.Name);
                grdReserveInfo.Columns.Insert(0, colSelect);
                colSelect.Frozen = true;
            }
            
            foreach (DataGridViewRow row in grdReserveInfo.Rows)
            {
                // 自己已预约
                if ((int) row.Cells["IsMyUsed"].Value == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    continue;
                }
                // 不可预约
                if (row.Cells["IsValid"].Value.ToString() == "0" || !string.IsNullOrEmpty(row.Cells["CarOrderID"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    continue;
                }
                // 空闲可预约
                if (row.Cells["CarOrderID"].Value == null || row.Cells["CarOrderID"].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
            foreach (DataGridViewColumn col in grdReserveInfo.Columns)
            {
                if (ResourceManagerUtil.GetStringDefaultNull(col.Name) == null)
                    col.Visible = false;
            }
        }

        private void grdReserveInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex != 0) return;
            var row = grdReserveInfo.Rows[e.RowIndex];
            if(row.Cells["IsValid"].Value.ToString() == "0" )//|| !string.IsNullOrEmpty(row.Cells["CarOrderID"].Value.ToString()))
               return;
            var checkd = row.Cells[e.ColumnIndex].Value ?? false;

            row.Cells[e.ColumnIndex].Value = !(bool)checkd;
        }


        #endregion

        private void btnReserve_Click(object sender, EventArgs e)
        {
            List<string> records = new List<string>();
            foreach (DataGridViewRow row in grdReserveInfo.Rows)
            {
                if (row.Cells[0].Value != null && (bool) row.Cells[0].Value)
                {
                    var recordId = row.Cells["RecordID"].Value.ToString();
                    records.Add(recordId);
                }
            }
            if(records.Count == 0) return;
            this.Cursor = Cursors.WaitCursor;
            string reserved = "";
            foreach (var recordId in records)
            {
                
                while (true)
                {
                    var apiCode = GetNewApiCode(false);
                    if (apiCode == null) continue;
                    var reserveResult = ExecuteReserve.Reserve(apiCode.Data, m_LoginInfo.RecordID, recordId);
                    if (!reserveResult.IsSuccessed)
                    {
                        ShowMessage(reserveResult.Message, true);
                        if (reserveResult.Message != "Error：本场次未开放，请预约其他场次！")
                        {
                            break;
                        }
                    }
                    else
                    {
                        reserved = recordId;
                        ShowMessage(reserveResult.Message, false);
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(reserved))
                    break;
            }

            if (string.IsNullOrEmpty(reserved))
            {
                MessageBox.Show("预约失败");
            }
            else
            {
                foreach (DataGridViewRow row in grdReserveInfo.Rows)
                {
                    if (row.Cells["RecordID"].Value.ToString() == reserved)
                    {
                        MessageBox.Show($"成功预约：{row.Cells["StartTime"].Value}-{row.Cells["EndTime"].Value}");
                    }
                }
            }
            m_ReserDateBtns[m_CurBtnIndex].PerformClick();
            this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdReserveInfo.Rows)
            {
                if ((int)row.Cells["IsMyUsed"].Value == 1)
                {
                    this.Cursor = Cursors.WaitCursor;
                    var orderId = row.Cells["CarOrderID"].Value.ToString();
                    var apiResult = GetNewApiCode();
                    if(apiResult == null) return;
                    var cancelResult = CancelReserve.Cancel(apiResult.Data, orderId);
                    MessageBox.Show(cancelResult.Message);
                    m_ReserDateBtns[m_CurBtnIndex].PerformClick();
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
        }

        private void ShowMessage(string message, bool isError)
        {
            var timeStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var msg = timeStr + " ： " + message + "\n";
            Color cor = Color.Green;
            if(isError) cor = Color.Red;
            int pos = txtMessage.TextLength - 1;
            pos = pos < 0 ? 0 : pos;
            txtMessage.AppendText(msg);
            txtMessage.SelectionStart = pos;
            txtMessage.SelectionLength = msg.Length;
            txtMessage.SelectionColor = cor;
            txtMessage.ScrollToCaret();
        }
    }
}
