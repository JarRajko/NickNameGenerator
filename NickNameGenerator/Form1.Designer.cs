namespace NickNameGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNouns = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxNouns
            // 
            textBoxNouns.Location = new Point(309, 101);
            textBoxNouns.Name = "textBoxNouns";
            textBoxNouns.Size = new Size(100, 23);
            textBoxNouns.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(215, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Generate!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxNouns);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Nick name generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNouns;
        private Button button1;
    }
}
