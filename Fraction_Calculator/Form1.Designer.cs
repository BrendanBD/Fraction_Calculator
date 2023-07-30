namespace Fraction_Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            txtFirstTop = new TextBox();
            txtFirstBottom = new TextBox();
            txtSecondTop = new TextBox();
            txtSecondBottom = new TextBox();
            txtResultTop = new TextBox();
            txtResultBottom = new TextBox();
            btnPerform = new Button();
            rbtnDivide = new RadioButton();
            rbtnMultiply = new RadioButton();
            rbtnSubtract = new RadioButton();
            rbtnPlus = new RadioButton();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 92);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "First";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 92);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Second";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 92);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 184);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 3;
            label4.Text = "=";
            // 
            // txtFirstTop
            // 
            txtFirstTop.Location = new Point(101, 139);
            txtFirstTop.Name = "txtFirstTop";
            txtFirstTop.Size = new Size(100, 23);
            txtFirstTop.TabIndex = 0;
            txtFirstTop.KeyPress += txtFirstTop_KeyPress;
            // 
            // txtFirstBottom
            // 
            txtFirstBottom.Location = new Point(101, 219);
            txtFirstBottom.Name = "txtFirstBottom";
            txtFirstBottom.Size = new Size(100, 23);
            txtFirstBottom.TabIndex = 1;
            txtFirstBottom.KeyPress += txtFirstBottom_KeyPress;
            // 
            // txtSecondTop
            // 
            txtSecondTop.Location = new Point(330, 139);
            txtSecondTop.Name = "txtSecondTop";
            txtSecondTop.Size = new Size(100, 23);
            txtSecondTop.TabIndex = 6;
            txtSecondTop.KeyPress += txtSecondTop_KeyPress;
            // 
            // txtSecondBottom
            // 
            txtSecondBottom.Location = new Point(330, 219);
            txtSecondBottom.Name = "txtSecondBottom";
            txtSecondBottom.Size = new Size(100, 23);
            txtSecondBottom.TabIndex = 7;
            txtSecondBottom.KeyPress += txtSecondBottom_KeyPress;
            // 
            // txtResultTop
            // 
            txtResultTop.Location = new Point(508, 139);
            txtResultTop.Name = "txtResultTop";
            txtResultTop.ReadOnly = true;
            txtResultTop.Size = new Size(100, 23);
            txtResultTop.TabIndex = 9;
            txtResultTop.TextChanged += txtResultTop_TextChanged;
            // 
            // txtResultBottom
            // 
            txtResultBottom.Location = new Point(508, 219);
            txtResultBottom.Name = "txtResultBottom";
            txtResultBottom.ReadOnly = true;
            txtResultBottom.Size = new Size(100, 23);
            txtResultBottom.TabIndex = 10;
            // 
            // btnPerform
            // 
            btnPerform.Location = new Point(258, 333);
            btnPerform.Name = "btnPerform";
            btnPerform.Size = new Size(219, 23);
            btnPerform.TabIndex = 8;
            btnPerform.Text = "Perform Operation";
            btnPerform.UseVisualStyleBackColor = true;
            btnPerform.Click += btnPerform_Click;
            // 
            // rbtnDivide
            // 
            rbtnDivide.AutoSize = true;
            rbtnDivide.Location = new Point(6, 42);
            rbtnDivide.Name = "rbtnDivide";
            rbtnDivide.Size = new Size(30, 19);
            rbtnDivide.TabIndex = 2;
            rbtnDivide.TabStop = true;
            rbtnDivide.Tag = "";
            rbtnDivide.Text = "/";
            rbtnDivide.UseVisualStyleBackColor = true;
            rbtnDivide.CheckedChanged += btnPerform_Click;
            // 
            // rbtnMultiply
            // 
            rbtnMultiply.AutoSize = true;
            rbtnMultiply.Location = new Point(6, 67);
            rbtnMultiply.Name = "rbtnMultiply";
            rbtnMultiply.Size = new Size(30, 19);
            rbtnMultiply.TabIndex = 3;
            rbtnMultiply.TabStop = true;
            rbtnMultiply.Tag = "";
            rbtnMultiply.Text = "*";
            rbtnMultiply.UseVisualStyleBackColor = true;
            rbtnMultiply.CheckedChanged += btnPerform_Click;
            // 
            // rbtnSubtract
            // 
            rbtnSubtract.AutoSize = true;
            rbtnSubtract.Location = new Point(6, 116);
            rbtnSubtract.Name = "rbtnSubtract";
            rbtnSubtract.Size = new Size(30, 19);
            rbtnSubtract.TabIndex = 5;
            rbtnSubtract.TabStop = true;
            rbtnSubtract.Tag = "-";
            rbtnSubtract.Text = "-";
            rbtnSubtract.UseVisualStyleBackColor = true;
            rbtnSubtract.CheckedChanged += btnPerform_Click;
            // 
            // rbtnPlus
            // 
            rbtnPlus.AutoSize = true;
            rbtnPlus.Location = new Point(6, 92);
            rbtnPlus.Name = "rbtnPlus";
            rbtnPlus.Size = new Size(33, 19);
            rbtnPlus.TabIndex = 4;
            rbtnPlus.TabStop = true;
            rbtnPlus.Tag = "+";
            rbtnPlus.Text = "+";
            rbtnPlus.UseVisualStyleBackColor = true;
            rbtnPlus.CheckedChanged += btnPerform_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnDivide);
            groupBox1.Controls.Add(rbtnSubtract);
            groupBox1.Controls.Add(rbtnPlus);
            groupBox1.Controls.Add(rbtnMultiply);
            groupBox1.Location = new Point(230, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(81, 170);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 188);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 12;
            label5.Text = "___________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 188);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 13;
            label6.Text = "___________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(506, 188);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 14;
            label7.Text = "___________________";
            // 
            // Form1
            // 
            AcceptButton = btnPerform;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(btnPerform);
            Controls.Add(txtResultBottom);
            Controls.Add(txtResultTop);
            Controls.Add(txtSecondBottom);
            Controls.Add(txtSecondTop);
            Controls.Add(txtFirstBottom);
            Controls.Add(txtFirstTop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Fraction Calculator";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox txtFirstTop;
        private TextBox txtFirstBottom;
        private TextBox txtSecondTop;
        private TextBox txtSecondBottom;
        private TextBox txtResultTop;
        private TextBox txtResultBottom;
        private Button btnPerform;
        private RadioButton rbtnDivide;
        private RadioButton rbtnMultiply;
        private RadioButton rbtnSubtract;
        private RadioButton rbtnPlus;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}