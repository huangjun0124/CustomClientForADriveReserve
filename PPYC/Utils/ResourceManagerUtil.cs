using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PPYC.Utils
{
    public class ResourceManagerUtil
    {
        public static string GetStringDefaultNull(string key)
        {
            var res = Properties.Resources.ResourceManager.GetString(key);
            return res;
        }

        public static string GetString(string key)
        {
            var res = Properties.Resources.ResourceManager.GetString(key);
            if (res == null) return key;
            return res;
        }

        public static void ChangeDatagridViewTitle(DataGridView grd)
        {
            foreach (DataGridViewColumn col in grd.Columns)
            {
                col.HeaderText = GetString(col.Name);
            }
        }
    }
}
