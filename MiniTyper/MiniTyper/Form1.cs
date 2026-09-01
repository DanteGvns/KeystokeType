using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            string textToType = textBoxInput.Text;
            if (string.IsNullOrWhiteSpace(textToType))
            {
                MessageBox.Show("Please enter text to type.");
                return;
            }

            // Wait 5 seconds so you can switch windows
            await Task.Delay(5000);

            // Send keystrokes to the active window
            SendKeys.SendWait(textToType);
        }
    }
}
