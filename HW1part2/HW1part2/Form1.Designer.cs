namespace HW1part2
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
            citezenStatus = new CheckBox();
            rebelStatus = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            birthYear = new TextBox();
            yearsInUS = new TextBox();
            terms = new TextBox();
            DisplayElgibility = new Button();
            SuspendLayout();
            // 
            // citezenStatus
            // 
            citezenStatus.AutoSize = true;
            citezenStatus.Location = new Point(12, 12);
            citezenStatus.Name = "citezenStatus";
            citezenStatus.Size = new Size(15, 14);
            citezenStatus.TabIndex = 0;
            citezenStatus.UseVisualStyleBackColor = true;
            citezenStatus.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // rebelStatus
            // 
            rebelStatus.AutoSize = true;
            rebelStatus.Location = new Point(6, 236);
            rebelStatus.Name = "rebelStatus";
            rebelStatus.Size = new Size(15, 14);
            rebelStatus.TabIndex = 1;
            rebelStatus.UseVisualStyleBackColor = true;
            rebelStatus.CheckedChanged += rebelStatus_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 13);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Nautrual Born Citzen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 237);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 3;
            label2.Text = "I have rebelled against the US";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 49);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 4;
            label3.Text = "What is your birth year?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 101);
            label4.Name = "label4";
            label4.Size = new Size(242, 15);
            label4.TabIndex = 5;
            label4.Text = "How many years have you resided in the US?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 157);
            label5.Name = "label5";
            label5.Size = new Size(191, 15);
            label5.TabIndex = 6;
            label5.Text = "How many terms have you served?";
            // 
            // birthYear
            // 
            birthYear.Location = new Point(18, 74);
            birthYear.Name = "birthYear";
            birthYear.Size = new Size(123, 23);
            birthYear.TabIndex = 7;
            birthYear.TextChanged += birthYear_TextChanged;
            // 
            // yearsInUS
            // 
            yearsInUS.Location = new Point(17, 129);
            yearsInUS.Name = "yearsInUS";
            yearsInUS.Size = new Size(100, 23);
            yearsInUS.TabIndex = 8;
            yearsInUS.TextChanged += yearsInUS_TextChanged;
            // 
            // terms
            // 
            terms.Location = new Point(17, 185);
            terms.Name = "terms";
            terms.Size = new Size(100, 23);
            terms.TabIndex = 9;
            terms.TextChanged += terms_TextChanged;
            // 
            // DisplayElgibility
            // 
            DisplayElgibility.Location = new Point(93, 318);
            DisplayElgibility.Name = "DisplayElgibility";
            DisplayElgibility.Size = new Size(96, 64);
            DisplayElgibility.TabIndex = 10;
            DisplayElgibility.Text = "Determine Elgibility";
            DisplayElgibility.UseVisualStyleBackColor = true;
            DisplayElgibility.Click += DisplayElgibility_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayElgibility);
            Controls.Add(terms);
            Controls.Add(yearsInUS);
            Controls.Add(birthYear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rebelStatus);
            Controls.Add(citezenStatus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox citezenStatus;
        private CheckBox rebelStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox birthYear;
        private TextBox yearsInUS;
        private TextBox terms;
        private Button DisplayElgibility;
    }
}