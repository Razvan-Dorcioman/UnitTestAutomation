using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationTests
{
    public static class ControlExtensions
    {
        public static async Task<bool> GetIdle(this TextBox txb, int waitTime = 1000)
        {
            var txt = txb.Text;
            await Task.Delay(waitTime);
            return txt == txb.Text;
        }

        public static async Task<bool> GetIdle(this NumericUpDown nud, int waitTime = 1000)
        {
            var txt = nud.Value;
            await Task.Delay(waitTime);
            return txt == nud.Value;
        }
    }
}