using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationTests
{
    public static class ControlExtensions
    {
        public static async Task<bool> GetIdle(this TextBox txb, int waitTime = 500)
        {
            string txt = txb.Text;
            await Task.Delay(waitTime);
            return txt == txb.Text;
        }
    }
}
