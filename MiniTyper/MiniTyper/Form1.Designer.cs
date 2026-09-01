namespace MiniTyper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.CheckBox CheckBoxShowPass;
        private bool isPasswordVisible = false;

        private System.Windows.Forms.Button buttonSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            FirstTextBox = new TextBox();
            SecondTextBox = new TextBox();
            buttonSubmit = new Button();
            CheckBoxShowPass = new CheckBox();
            SuspendLayout();
            // 
            // FirstTextBox
            // 
            FirstTextBox.Location = new Point(12, 12);
            FirstTextBox.Name = "FirstTextBox";
            FirstTextBox.Size = new Size(360, 23);
            FirstTextBox.TabIndex = 0;
            // 
            // SecondTextBox
            // 
            SecondTextBox.Location = new Point(12, 41);
            SecondTextBox.Name = "SecondTextBox";
            SecondTextBox.Size = new Size(360, 23);
            SecondTextBox.TabIndex = 1;
            SecondTextBox.UseSystemPasswordChar = true;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(12, 70);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(100, 30);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // CheckBoxShowPass
            // 
            CheckBoxShowPass.Location = new Point(225, 70);
            CheckBoxShowPass.Name = "CheckBoxShowPass";
            CheckBoxShowPass.Size = new Size(120, 30);
            CheckBoxShowPass.TabIndex = 3;
            CheckBoxShowPass.Text = "Show Password";
            CheckBoxShowPass.UseVisualStyleBackColor = true;
            CheckBoxShowPass.CheckedChanged += CheckBoxShowPass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 109);
            Controls.Add(CheckBoxShowPass);
            Controls.Add(buttonSubmit);
            Controls.Add(FirstTextBox);
            Controls.Add(SecondTextBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini Typer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

    }
}

