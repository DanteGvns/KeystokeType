namespace MiniTyper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
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
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(12, 12);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(360, 23);
            this.FirstTextBox.TabIndex = 0;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(12, 41);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(360, 23);
            this.SecondTextBox.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 70);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 30);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.FirstTextBox);
            this.Controls.Add(this.SecondTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Typer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

