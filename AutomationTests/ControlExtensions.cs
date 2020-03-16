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
    }
}