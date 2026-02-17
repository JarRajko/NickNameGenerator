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
            adjectiveButton = new Button();
            numerizeCheckbox = new CheckBox();
            numberButton = new Button();
            prefixButton = new Button();
            postfixButton = new Button();
            numberizeButton = new Button();
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
            // 
            // adjectiveButton
            // 
            adjectiveButton.Location = new Point(93, 75);
            adjectiveButton.Name = "adjectiveButton";
            adjectiveButton.Size = new Size(100, 23);
            adjectiveButton.TabIndex = 7;
            adjectiveButton.Text = "Apply changes";
            adjectiveButton.UseVisualStyleBackColor = true;
            adjectiveButton.Click += adjectiveButton_Click;
            // 
            // numerizeCheckbox
            // 
            numerizeCheckbox.AutoSize = true;
            numerizeCheckbox.Location = new Point(12, 179);
            numerizeCheckbox.Name = "numerizeCheckbox";
            numerizeCheckbox.Size = new Size(84, 19);
            numerizeCheckbox.TabIndex = 8;
            numerizeCheckbox.Text = "Numberize";
            numerizeCheckbox.UseVisualStyleBackColor = true;
            numerizeCheckbox.CheckedChanged += numerizeCheckbox_CheckedChanged;
            // 
            // numberButton
            // 
            numberButton.Location = new Point(93, 101);
            numberButton.Name = "numberButton";
            numberButton.Size = new Size(100, 23);
            numberButton.TabIndex = 9;
            numberButton.Text = "Apply changes";
            numberButton.UseVisualStyleBackColor = true;
            numberButton.Click += numberButton_Click;
            // 
            // prefixButton
            // 
            prefixButton.Location = new Point(93, 125);
            prefixButton.Name = "prefixButton";
            prefixButton.Size = new Size(100, 23);
            prefixButton.TabIndex = 10;
            prefixButton.Text = "Apply changes";
            prefixButton.UseVisualStyleBackColor = true;
            prefixButton.Click += prefixButton_Click;
            // 
            // postfixButton
            // 
            postfixButton.Location = new Point(93, 150);
            postfixButton.Name = "postfixButton";
            postfixButton.Size = new Size(100, 23);
            postfixButton.TabIndex = 11;
            postfixButton.Text = "Apply changes";
            postfixButton.UseVisualStyleBackColor = true;
            postfixButton.Click += postfixButton_Click;
            // 
            // numberizeButton
            // 
            numberizeButton.Location = new Point(93, 175);
            numberizeButton.Name = "numberizeButton";
            numberizeButton.Size = new Size(100, 23);
            numberizeButton.TabIndex = 12;
            numberizeButton.Text = "Apply changes";
            numberizeButton.UseVisualStyleBackColor = true;
            numberizeButton.Click += numberizeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(562, 236);
            Controls.Add(numberizeButton);
            Controls.Add(postfixButton);
            Controls.Add(prefixButton);
            Controls.Add(numberButton);
            Controls.Add(numerizeCheckbox);
            Controls.Add(adjectiveButton);
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
        private Button adjectiveButton;
        private CheckBox numerizeCheckbox;
        private Button numberButton;
        private Button prefixButton;
        private Button postfixButton;
        private Button numberizeButton;
    }
}
