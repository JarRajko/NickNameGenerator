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
            checkBoxAdjective = new CheckBox();
            checkBoxNumber = new CheckBox();
            checkBoxPrefix = new CheckBox();
            checkBoxPostfix = new CheckBox();
            SuspendLayout();
            // 
            // textBoxNouns
            // 
            textBoxNouns.Location = new Point(309, 101);
            textBoxNouns.Name = "textBoxNouns";
            textBoxNouns.Size = new Size(316, 23);
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
            // checkBoxAdjective
            // 
            checkBoxAdjective.AutoSize = true;
            checkBoxAdjective.Location = new Point(215, 136);
            checkBoxAdjective.Name = "checkBoxAdjective";
            checkBoxAdjective.Size = new Size(75, 19);
            checkBoxAdjective.TabIndex = 2;
            checkBoxAdjective.Text = "Adjective";
            checkBoxAdjective.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumber
            // 
            checkBoxNumber.AutoSize = true;
            checkBoxNumber.Location = new Point(215, 161);
            checkBoxNumber.Name = "checkBoxNumber";
            checkBoxNumber.Size = new Size(70, 19);
            checkBoxNumber.TabIndex = 3;
            checkBoxNumber.Text = "Number";
            checkBoxNumber.TextAlign = ContentAlignment.BottomCenter;
            checkBoxNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrefix
            // 
            checkBoxPrefix.AutoSize = true;
            checkBoxPrefix.Location = new Point(215, 186);
            checkBoxPrefix.Name = "checkBoxPrefix";
            checkBoxPrefix.Size = new Size(56, 19);
            checkBoxPrefix.TabIndex = 4;
            checkBoxPrefix.Text = "Prefix";
            checkBoxPrefix.UseVisualStyleBackColor = true;
            // 
            // checkBoxPostfix
            // 
            checkBoxPostfix.AutoSize = true;
            checkBoxPostfix.Location = new Point(215, 211);
            checkBoxPostfix.Name = "checkBoxPostfix";
            checkBoxPostfix.Size = new Size(62, 19);
            checkBoxPostfix.TabIndex = 5;
            checkBoxPostfix.Text = "Postfix";
            checkBoxPostfix.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxPostfix);
            Controls.Add(checkBoxPrefix);
            Controls.Add(checkBoxNumber);
            Controls.Add(checkBoxAdjective);
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
        private CheckBox checkBoxAdjective;
        private CheckBox checkBoxNumber;
        private CheckBox checkBoxPrefix;
        private CheckBox checkBoxPostfix;
    }
}
