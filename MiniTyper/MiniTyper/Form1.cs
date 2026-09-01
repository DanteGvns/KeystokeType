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
            string firstInput = FirstTextBox.Text;
            string secondInput = SecondTextBox.Text;
            if (string.IsNullOrWhiteSpace(firstInput) && string.IsNullOrWhiteSpace(secondInput))
            {
                MessageBox.Show("Please enter text to type.");
                return;
            } else if (!string.IsNullOrWhiteSpace(firstInput) && string.IsNullOrWhiteSpace(secondInput)){
                // Wait 3 seconds so you can switch windows
                await Task.Delay(3000);

                // Send Only the first line to the active window
                SendKeys.SendWait(firstInput);
                return;

            } else if (!string.IsNullOrWhiteSpace(firstInput) && !string.IsNullOrWhiteSpace(secondInput)){
                // Wait 3 seconds so you can switch windows
                await Task.Delay(3000);

                // Send first and second line to the active window
                SendKeys.SendWait(firstInput);
                SendKeys.SendWait("{TAB}");
                SendKeys.SendWait(secondInput);
                return;

            } else if (string.IsNullOrWhiteSpace(firstInput) && string.IsNullOrWhiteSpace(secondInput))
            {
                MessageBox.Show("Please enter a username.");
                return;
            } else
            {
                MessageBox.Show("Error: Conditons not met");
                return;
            }

        }
    }
}
