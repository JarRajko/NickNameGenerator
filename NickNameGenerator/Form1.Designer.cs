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
            button1 = new Button();
            checkBoxAdjective = new CheckBox();
            checkBoxNumber = new CheckBox();
            checkBoxPrefix = new CheckBox();
            checkBoxPostfix = new CheckBox();
            labelText = new Label();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 5);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 1;
            button1.Text = "Generate!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBoxAdjective
            // 
            checkBoxAdjective.AutoSize = true;
            checkBoxAdjective.Location = new Point(12, 79);
            checkBoxAdjective.Name = "checkBoxAdjective";
            checkBoxAdjective.Size = new Size(75, 19);
            checkBoxAdjective.TabIndex = 2;
            checkBoxAdjective.Text = "Adjective";
            checkBoxAdjective.UseVisualStyleBackColor = true;
            checkBoxAdjective.CheckedChanged += checkBoxAdjective_CheckedChanged;
            // 
            // checkBoxNumber
            // 
            checkBoxNumber.AutoSize = true;
            checkBoxNumber.Location = new Point(12, 104);
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
            checkBoxPrefix.Location = new Point(12, 129);
            checkBoxPrefix.Name = "checkBoxPrefix";
            checkBoxPrefix.Size = new Size(56, 19);
            checkBoxPrefix.TabIndex = 4;
            checkBoxPrefix.Text = "Prefix";
            checkBoxPrefix.UseVisualStyleBackColor = true;
            // 
            // checkBoxPostfix
            // 
            checkBoxPostfix.AutoSize = true;
            checkBoxPostfix.Location = new Point(12, 154);
            checkBoxPostfix.Name = "checkBoxPostfix";
            checkBoxPostfix.Size = new Size(62, 19);
            checkBoxPostfix.TabIndex = 5;
            checkBoxPostfix.Text = "Postfix";
            checkBoxPostfix.UseVisualStyleBackColor = true;
            // 
            // labelText
            // 
            labelText.Location = new Point(234, 5);
            labelText.Name = "labelText";
            labelText.Size = new Size(316, 23);
            labelText.TabIndex = 6;
            labelText.Click += labelText_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 34);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 7;
            button2.Text = "Apply changes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 179);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Numberize";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(562, 236);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(labelText);
            Controls.Add(checkBoxPostfix);
            Controls.Add(checkBoxPrefix);
            Controls.Add(checkBoxNumber);
            Controls.Add(checkBoxAdjective);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Nick name generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private CheckBox checkBoxAdjective;
        private CheckBox checkBoxNumber;
        private CheckBox checkBoxPrefix;
        private CheckBox checkBoxPostfix;
        private Label labelText;
        private Button button2;
        private CheckBox checkBox1;
    }
}
