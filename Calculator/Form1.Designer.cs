namespace Calculator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Keypad = new TableLayoutPanel();
            Press0 = new Button();
            CalculatorPercentage = new Button();
            Press3 = new Button();
            Press2 = new Button();
            Press1 = new Button();
            button12 = new Button();
            Press6 = new Button();
            Press5 = new Button();
            Press4 = new Button();
            CalcultorMultiply = new Button();
            Press9 = new Button();
            Press8 = new Button();
            Press7 = new Button();
            CalculatorClear = new Button();
            CalculatorDelete = new Button();
            CalculatorParenthesesClose = new Button();
            CalculatorParenthesesOpen = new Button();
            CalculatorEqual = new Button();
            CalculatorSubtract = new Button();
            CalculatorAdd = new Button();
            InputDisplay = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            Keypad.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Keypad, 0, 1);
            tableLayoutPanel1.Controls.Add(InputDisplay, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(437, 503);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Keypad
            // 
            Keypad.AccessibleName = "Keypad";
            Keypad.ColumnCount = 4;
            Keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Keypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Keypad.Controls.Add(Press0, 1, 4);
            Keypad.Controls.Add(CalculatorPercentage, 0, 4);
            Keypad.Controls.Add(Press3, 2, 3);
            Keypad.Controls.Add(Press2, 1, 3);
            Keypad.Controls.Add(Press1, 0, 3);
            Keypad.Controls.Add(button12, 3, 2);
            Keypad.Controls.Add(Press6, 2, 2);
            Keypad.Controls.Add(Press5, 1, 2);
            Keypad.Controls.Add(Press4, 0, 2);
            Keypad.Controls.Add(CalcultorMultiply, 3, 1);
            Keypad.Controls.Add(Press9, 2, 1);
            Keypad.Controls.Add(Press8, 1, 1);
            Keypad.Controls.Add(Press7, 0, 1);
            Keypad.Controls.Add(CalculatorClear, 3, 0);
            Keypad.Controls.Add(CalculatorDelete, 2, 0);
            Keypad.Controls.Add(CalculatorParenthesesClose, 1, 0);
            Keypad.Controls.Add(CalculatorParenthesesOpen, 0, 0);
            Keypad.Controls.Add(CalculatorEqual, 2, 4);
            Keypad.Controls.Add(CalculatorSubtract, 3, 4);
            Keypad.Controls.Add(CalculatorAdd, 3, 3);
            Keypad.Dock = DockStyle.Fill;
            Keypad.Location = new Point(3, 103);
            Keypad.Name = "Keypad";
            Keypad.RowCount = 5;
            Keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Keypad.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Keypad.Size = new Size(431, 397);
            Keypad.TabIndex = 1;
            // 
            // Press0
            // 
            Press0.AccessibleName = "Press0";
            Press0.Anchor = AnchorStyles.None;
            Press0.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press0.Location = new Point(123, 329);
            Press0.Name = "Press0";
            Press0.Size = new Size(75, 55);
            Press0.TabIndex = 17;
            Press0.Text = "0";
            Press0.UseVisualStyleBackColor = true;
            Press0.Click += TextButtonDisplay;
            // 
            // CalculatorPercentage
            // 
            CalculatorPercentage.AccessibleName = "CalculatorDecimal";
            CalculatorPercentage.Anchor = AnchorStyles.None;
            CalculatorPercentage.Font = new Font("Calibri", 12F, FontStyle.Bold);
            CalculatorPercentage.Location = new Point(16, 329);
            CalculatorPercentage.Name = "CalculatorPercentage";
            CalculatorPercentage.Size = new Size(75, 55);
            CalculatorPercentage.TabIndex = 16;
            CalculatorPercentage.Text = ",";
            CalculatorPercentage.UseVisualStyleBackColor = true;
            CalculatorPercentage.Click += TextButtonDisplay;
            // 
            // Press3
            // 
            Press3.AccessibleName = "Press3";
            Press3.Anchor = AnchorStyles.None;
            Press3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press3.Location = new Point(230, 249);
            Press3.Name = "Press3";
            Press3.Size = new Size(75, 55);
            Press3.TabIndex = 14;
            Press3.Text = "3";
            Press3.UseVisualStyleBackColor = true;
            Press3.Click += TextButtonDisplay;
            // 
            // Press2
            // 
            Press2.AccessibleName = "Press2";
            Press2.Anchor = AnchorStyles.None;
            Press2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press2.Location = new Point(123, 249);
            Press2.Name = "Press2";
            Press2.Size = new Size(75, 55);
            Press2.TabIndex = 13;
            Press2.Text = "2";
            Press2.UseVisualStyleBackColor = true;
            Press2.Click += TextButtonDisplay;
            // 
            // Press1
            // 
            Press1.AccessibleName = "Press1";
            Press1.Anchor = AnchorStyles.None;
            Press1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press1.Location = new Point(16, 249);
            Press1.Name = "Press1";
            Press1.Size = new Size(75, 55);
            Press1.TabIndex = 12;
            Press1.Text = "1";
            Press1.UseVisualStyleBackColor = true;
            Press1.Click += TextButtonDisplay;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.None;
            button12.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(338, 170);
            button12.Name = "button12";
            button12.Size = new Size(75, 55);
            button12.TabIndex = 11;
            button12.Text = "÷";
            button12.UseVisualStyleBackColor = true;
            button12.Click += OperatorButtonClick;
            // 
            // Press6
            // 
            Press6.AccessibleName = "Press6";
            Press6.Anchor = AnchorStyles.None;
            Press6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press6.Location = new Point(230, 170);
            Press6.Name = "Press6";
            Press6.Size = new Size(75, 55);
            Press6.TabIndex = 10;
            Press6.Text = "6";
            Press6.UseVisualStyleBackColor = true;
            Press6.Click += TextButtonDisplay;
            // 
            // Press5
            // 
            Press5.AccessibleName = "Press5";
            Press5.Anchor = AnchorStyles.None;
            Press5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press5.Location = new Point(123, 170);
            Press5.Name = "Press5";
            Press5.Size = new Size(75, 55);
            Press5.TabIndex = 9;
            Press5.Text = "5";
            Press5.UseVisualStyleBackColor = true;
            Press5.Click += TextButtonDisplay;
            // 
            // Press4
            // 
            Press4.AccessibleName = "Press4";
            Press4.Anchor = AnchorStyles.None;
            Press4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press4.Location = new Point(16, 170);
            Press4.Name = "Press4";
            Press4.Size = new Size(75, 55);
            Press4.TabIndex = 8;
            Press4.Text = "4";
            Press4.UseVisualStyleBackColor = true;
            Press4.Click += TextButtonDisplay;
            // 
            // CalcultorMultiply
            // 
            CalcultorMultiply.AccessibleName = "CalculatorMultiply";
            CalcultorMultiply.Anchor = AnchorStyles.None;
            CalcultorMultiply.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalcultorMultiply.Location = new Point(338, 91);
            CalcultorMultiply.Name = "CalcultorMultiply";
            CalcultorMultiply.Size = new Size(75, 55);
            CalcultorMultiply.TabIndex = 7;
            CalcultorMultiply.Text = "X";
            CalcultorMultiply.UseVisualStyleBackColor = true;
            CalcultorMultiply.Click += OperatorButtonClick;
            // 
            // Press9
            // 
            Press9.AccessibleName = "Press9";
            Press9.Anchor = AnchorStyles.None;
            Press9.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press9.Location = new Point(230, 91);
            Press9.Name = "Press9";
            Press9.Size = new Size(75, 55);
            Press9.TabIndex = 6;
            Press9.Text = "9";
            Press9.UseVisualStyleBackColor = true;
            Press9.Click += TextButtonDisplay;
            // 
            // Press8
            // 
            Press8.AccessibleName = "Press8";
            Press8.Anchor = AnchorStyles.None;
            Press8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press8.Location = new Point(123, 91);
            Press8.Name = "Press8";
            Press8.Size = new Size(75, 55);
            Press8.TabIndex = 5;
            Press8.Text = "8";
            Press8.UseVisualStyleBackColor = true;
            Press8.Click += TextButtonDisplay;
            // 
            // Press7
            // 
            Press7.AccessibleName = "Press7";
            Press7.Anchor = AnchorStyles.None;
            Press7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Press7.Location = new Point(16, 91);
            Press7.Name = "Press7";
            Press7.Size = new Size(75, 55);
            Press7.TabIndex = 4;
            Press7.Text = "7";
            Press7.UseVisualStyleBackColor = true;
            Press7.Click += TextButtonDisplay;
            // 
            // CalculatorClear
            // 
            CalculatorClear.AccessibleName = "CaclulatorClear";
            CalculatorClear.Anchor = AnchorStyles.None;
            CalculatorClear.Font = new Font("Calibri", 12F, FontStyle.Bold);
            CalculatorClear.Location = new Point(338, 12);
            CalculatorClear.Name = "CalculatorClear";
            CalculatorClear.Size = new Size(75, 55);
            CalculatorClear.TabIndex = 3;
            CalculatorClear.Text = "AC";
            CalculatorClear.UseVisualStyleBackColor = true;
            CalculatorClear.Click += CalculatorClear_Click;
            // 
            // CalculatorDelete
            // 
            CalculatorDelete.AccessibleName = "CalculatorDelete";
            CalculatorDelete.Anchor = AnchorStyles.None;
            CalculatorDelete.Font = new Font("Calibri", 12F, FontStyle.Bold);
            CalculatorDelete.Location = new Point(230, 12);
            CalculatorDelete.Name = "CalculatorDelete";
            CalculatorDelete.Size = new Size(75, 55);
            CalculatorDelete.TabIndex = 2;
            CalculatorDelete.Text = "DEL";
            CalculatorDelete.UseVisualStyleBackColor = true;
            CalculatorDelete.Click += CalculatorDelete_Click;
            // 
            // CalculatorParenthesesClose
            // 
            CalculatorParenthesesClose.AccessibleName = "CalculatorParenthesesClose";
            CalculatorParenthesesClose.Anchor = AnchorStyles.None;
            CalculatorParenthesesClose.Font = new Font("Calibri", 12F, FontStyle.Bold);
            CalculatorParenthesesClose.Location = new Point(123, 12);
            CalculatorParenthesesClose.Name = "CalculatorParenthesesClose";
            CalculatorParenthesesClose.Size = new Size(75, 55);
            CalculatorParenthesesClose.TabIndex = 1;
            CalculatorParenthesesClose.Text = ")";
            CalculatorParenthesesClose.UseVisualStyleBackColor = true;
            CalculatorParenthesesClose.Click += TextButtonDisplay;
            // 
            // CalculatorParenthesesOpen
            // 
            CalculatorParenthesesOpen.AccessibleName = "CalculatorParenthesesOpen";
            CalculatorParenthesesOpen.Anchor = AnchorStyles.None;
            CalculatorParenthesesOpen.Font = new Font("Calibri", 12F, FontStyle.Bold);
            CalculatorParenthesesOpen.Location = new Point(16, 12);
            CalculatorParenthesesOpen.Name = "CalculatorParenthesesOpen";
            CalculatorParenthesesOpen.Size = new Size(75, 55);
            CalculatorParenthesesOpen.TabIndex = 0;
            CalculatorParenthesesOpen.Text = "(";
            CalculatorParenthesesOpen.UseVisualStyleBackColor = true;
            CalculatorParenthesesOpen.Click += TextButtonDisplay;
            // 
            // CalculatorEqual
            // 
            CalculatorEqual.AccessibleName = "CalculatorEqual";
            CalculatorEqual.Anchor = AnchorStyles.None;
            CalculatorEqual.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalculatorEqual.Location = new Point(230, 329);
            CalculatorEqual.Name = "CalculatorEqual";
            CalculatorEqual.Size = new Size(75, 55);
            CalculatorEqual.TabIndex = 19;
            CalculatorEqual.Text = "=";
            CalculatorEqual.UseVisualStyleBackColor = true;
            CalculatorEqual.Click += CalculatorEqual_Click;
            // 
            // CalculatorSubtract
            // 
            CalculatorSubtract.AccessibleName = "CalculatorSubtract";
            CalculatorSubtract.Anchor = AnchorStyles.None;
            CalculatorSubtract.Font = new Font("Calibri", 18F);
            CalculatorSubtract.Location = new Point(338, 329);
            CalculatorSubtract.Name = "CalculatorSubtract";
            CalculatorSubtract.Size = new Size(75, 55);
            CalculatorSubtract.TabIndex = 18;
            CalculatorSubtract.Text = "-";
            CalculatorSubtract.UseVisualStyleBackColor = true;
            CalculatorSubtract.Click += OperatorButtonClick;
            // 
            // CalculatorAdd
            // 
            CalculatorAdd.AccessibleName = "CalculatorAdd";
            CalculatorAdd.Anchor = AnchorStyles.None;
            CalculatorAdd.Font = new Font("Calibri", 18F);
            CalculatorAdd.Location = new Point(338, 249);
            CalculatorAdd.Name = "CalculatorAdd";
            CalculatorAdd.Size = new Size(75, 55);
            CalculatorAdd.TabIndex = 15;
            CalculatorAdd.Text = "+";
            CalculatorAdd.UseVisualStyleBackColor = true;
            CalculatorAdd.Click += OperatorButtonClick;
            // 
            // InputDisplay
            // 
            InputDisplay.AccessibleName = "InputDisplay";
            InputDisplay.Anchor = AnchorStyles.None;
            InputDisplay.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputDisplay.Location = new Point(7, 15);
            InputDisplay.Name = "InputDisplay";
            InputDisplay.Size = new Size(422, 69);
            InputDisplay.TabIndex = 0;
            InputDisplay.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 503);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            Keypad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel Keypad;
        private Button CalculatorEqual;
        private Button CalculatorSubtract;
        private Button Press0;
        private Button CalculatorPercentage;
        private Button CalculatorAdd;
        private Button Press3;
        private Button Press2;
        private Button Press1;
        private Button button12;
        private Button Press6;
        private Button Press5;
        private Button Press4;
        private Button CalcultorMultiply;
        private Button Press9;
        private Button Press8;
        private Button Press7;
        private Button CalculatorClear;
        private Button CalculatorDelete;
        private Button CalculatorParenthesesClose;
        private Button CalculatorParenthesesOpen;
        public RichTextBox InputDisplay;
    }
}
