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
            copyButton = new Button();
            randomButton = new Button();
            lengthTrackBar = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)lengthTrackBar).BeginInit();
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
            checkBoxAdjective.Location = new Point(12, 150);
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
            checkBoxNumber.Location = new Point(12, 175);
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
            checkBoxPrefix.Location = new Point(12, 200);
            checkBoxPrefix.Name = "checkBoxPrefix";
            checkBoxPrefix.Size = new Size(56, 19);
            checkBoxPrefix.TabIndex = 4;
            checkBoxPrefix.Text = "Prefix";
            checkBoxPrefix.UseVisualStyleBackColor = true;
            // 
            // checkBoxPostfix
            // 
            checkBoxPostfix.AutoSize = true;
            checkBoxPostfix.Location = new Point(12, 225);
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
            adjectiveButton.Location = new Point(91, 146);
            adjectiveButton.Name = "adjectiveButton";
            adjectiveButton.Size = new Size(102, 23);
            adjectiveButton.TabIndex = 7;
            adjectiveButton.Text = "Apply changes";
            adjectiveButton.UseVisualStyleBackColor = true;
            adjectiveButton.Click += adjectiveButton_Click;
            // 
            // numerizeCheckbox
            // 
            numerizeCheckbox.AutoSize = true;
            numerizeCheckbox.Location = new Point(12, 250);
            numerizeCheckbox.Name = "numerizeCheckbox";
            numerizeCheckbox.Size = new Size(84, 19);
            numerizeCheckbox.TabIndex = 8;
            numerizeCheckbox.Text = "Numberize";
            numerizeCheckbox.UseVisualStyleBackColor = true;
            numerizeCheckbox.CheckedChanged += numerizeCheckbox_CheckedChanged;
            // 
            // numberButton
            // 
            numberButton.Location = new Point(91, 172);
            numberButton.Name = "numberButton";
            numberButton.Size = new Size(102, 23);
            numberButton.TabIndex = 9;
            numberButton.Text = "Apply changes";
            numberButton.UseVisualStyleBackColor = true;
            numberButton.Click += numberButton_Click;
            // 
            // prefixButton
            // 
            prefixButton.Location = new Point(91, 196);
            prefixButton.Name = "prefixButton";
            prefixButton.Size = new Size(102, 23);
            prefixButton.TabIndex = 10;
            prefixButton.Text = "Apply changes";
            prefixButton.UseVisualStyleBackColor = true;
            prefixButton.Click += prefixButton_Click;
            // 
            // postfixButton
            // 
            postfixButton.Location = new Point(91, 221);
            postfixButton.Name = "postfixButton";
            postfixButton.Size = new Size(102, 23);
            postfixButton.TabIndex = 11;
            postfixButton.Text = "Apply changes";
            postfixButton.UseVisualStyleBackColor = true;
            postfixButton.Click += postfixButton_Click;
            // 
            // numberizeButton
            // 
            numberizeButton.Location = new Point(91, 246);
            numberizeButton.Name = "numberizeButton";
            numberizeButton.Size = new Size(102, 23);
            numberizeButton.TabIndex = 12;
            numberizeButton.Text = "Apply changes";
            numberizeButton.UseVisualStyleBackColor = true;
            numberizeButton.Click += numberizeButton_Click;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(323, 31);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(134, 23);
            copyButton.TabIndex = 13;
            copyButton.Text = "Copy to clipboard!";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(12, 50);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(127, 23);
            randomButton.TabIndex = 14;
            randomButton.Text = "Generate random!";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // lengthTrackBar
            // 
            lengthTrackBar.Location = new Point(12, 79);
            lengthTrackBar.Maximum = 15;
            lengthTrackBar.Minimum = 3;
            lengthTrackBar.Name = "lengthTrackBar";
            lengthTrackBar.Size = new Size(127, 45);
            lengthTrackBar.TabIndex = 15;
            lengthTrackBar.Value = 3;
            lengthTrackBar.Scroll += lengthTrackBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 16;
            label1.Text = "Nickname length 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(562, 298);
            Controls.Add(label1);
            Controls.Add(lengthTrackBar);
            Controls.Add(randomButton);
            Controls.Add(copyButton);
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
            ((System.ComponentModel.ISupportInitialize)lengthTrackBar).EndInit();
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
        private Button copyButton;
        private Button randomButton;
        private TrackBar lengthTrackBar;
        private Label label1;
    }
}
