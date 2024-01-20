namespace FunPro.CW2._19248
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
            cbxPlayer1 = new ComboBox();
            cbxPlayer2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            bnRollDice = new Button();
            SuspendLayout();
            // 
            // cbxPlayer1
            // 
            cbxPlayer1.FormattingEnabled = true;
            cbxPlayer1.Location = new Point(90, 20);
            cbxPlayer1.Name = "cbxPlayer1";
            cbxPlayer1.Size = new Size(121, 23);
            cbxPlayer1.TabIndex = 0;
            // 
            // cbxPlayer2
            // 
            cbxPlayer2.FormattingEnabled = true;
            cbxPlayer2.Location = new Point(434, 20);
            cbxPlayer2.Name = "cbxPlayer2";
            cbxPlayer2.Size = new Size(121, 23);
            cbxPlayer2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Player 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 23);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Player 2";
            // 
            // bnRollDice
            // 
            bnRollDice.Location = new Point(254, 175);
            bnRollDice.Name = "bnRollDice";
            bnRollDice.Size = new Size(119, 41);
            bnRollDice.TabIndex = 4;
            bnRollDice.Text = "Roll the dice";
            bnRollDice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 252);
            Controls.Add(bnRollDice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxPlayer2);
            Controls.Add(cbxPlayer1);
            Name = "Form1";
            Text = "Dice Wars";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxPlayer1;
        private ComboBox cbxPlayer2;
        private Label label1;
        private Label label2;
        private Button bnRollDice;
    }
}