namespace CalculatorApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_res = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.simbol = new System.Windows.Forms.Button();
            this.remainder = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.mutiple = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_res
            // 
            this.text_res.Location = new System.Drawing.Point(22, 12);
            this.text_res.Multiline = true;
            this.text_res.Name = "text_res";
            this.text_res.Size = new System.Drawing.Size(589, 89);
            this.text_res.TabIndex = 0;
            this.text_res.TextChanged += new System.EventHandler(this.text_res_TextChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(22, 133);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 72);
            this.clear.TabIndex = 1;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // simbol
            // 
            this.simbol.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.simbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simbol.Location = new System.Drawing.Point(177, 133);
            this.simbol.Name = "simbol";
            this.simbol.Size = new System.Drawing.Size(123, 72);
            this.simbol.TabIndex = 2;
            this.simbol.Text = "+/-";
            this.simbol.UseVisualStyleBackColor = false;
            this.simbol.Click += new System.EventHandler(this.simbol_Click);
            // 
            // remainder
            // 
            this.remainder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.remainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainder.Location = new System.Drawing.Point(331, 133);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(123, 72);
            this.remainder.TabIndex = 3;
            this.remainder.Text = "%";
            this.remainder.UseVisualStyleBackColor = false;
            this.remainder.Click += new System.EventHandler(this.remainder_Click);
            // 
            // devide
            // 
            this.devide.BackColor = System.Drawing.Color.Chocolate;
            this.devide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devide.Location = new System.Drawing.Point(488, 133);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(123, 72);
            this.devide.TabIndex = 4;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = false;
            this.devide.Click += new System.EventHandler(this.devide_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(22, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 72);
            this.button5.TabIndex = 5;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(177, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 72);
            this.button6.TabIndex = 6;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(331, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 72);
            this.button7.TabIndex = 7;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // mutiple
            // 
            this.mutiple.BackColor = System.Drawing.Color.Chocolate;
            this.mutiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutiple.Location = new System.Drawing.Point(488, 230);
            this.mutiple.Name = "mutiple";
            this.mutiple.Size = new System.Drawing.Size(123, 72);
            this.mutiple.TabIndex = 8;
            this.mutiple.Text = "x";
            this.mutiple.UseVisualStyleBackColor = false;
            this.mutiple.Click += new System.EventHandler(this.mutiple_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(22, 334);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 72);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(177, 334);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 72);
            this.button10.TabIndex = 10;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(331, 334);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(123, 72);
            this.button11.TabIndex = 11;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // substract
            // 
            this.substract.BackColor = System.Drawing.Color.Chocolate;
            this.substract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substract.Location = new System.Drawing.Point(488, 334);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(123, 72);
            this.substract.TabIndex = 12;
            this.substract.Text = "-";
            this.substract.UseVisualStyleBackColor = false;
            this.substract.Click += new System.EventHandler(this.substract_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(22, 438);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(123, 72);
            this.button13.TabIndex = 13;
            this.button13.Text = "7";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(177, 438);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(123, 72);
            this.button14.TabIndex = 14;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(331, 438);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(123, 72);
            this.button15.TabIndex = 15;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Chocolate;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(488, 438);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 72);
            this.add.TabIndex = 16;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(22, 541);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(278, 72);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(331, 541);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(123, 72);
            this.dot.TabIndex = 18;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Chocolate;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(488, 541);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(123, 72);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(633, 651);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.mutiple);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.simbol);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.text_res);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_res;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button simbol;
        private System.Windows.Forms.Button remainder;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button mutiple;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
    }
}

