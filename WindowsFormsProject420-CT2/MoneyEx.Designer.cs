namespace WindowsFormsProject420_CT2
{
    partial class MoneyEx
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
            this.btnFromCAD = new System.Windows.Forms.RadioButton();
            this.btnFromUSD = new System.Windows.Forms.RadioButton();
            this.btnFromEUR = new System.Windows.Forms.RadioButton();
            this.btnFromGBP = new System.Windows.Forms.RadioButton();
            this.textboxfrom = new System.Windows.Forms.TextBox();
            this.textboxto = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnToGBP = new System.Windows.Forms.RadioButton();
            this.btnToEUR = new System.Windows.Forms.RadioButton();
            this.btnToUSD = new System.Windows.Forms.RadioButton();
            this.btnToCAD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFromCAD
            // 
            this.btnFromCAD.AutoSize = true;
            this.btnFromCAD.Location = new System.Drawing.Point(11, 31);
            this.btnFromCAD.Name = "btnFromCAD";
            this.btnFromCAD.Size = new System.Drawing.Size(57, 20);
            this.btnFromCAD.TabIndex = 4;
            this.btnFromCAD.TabStop = true;
            this.btnFromCAD.Text = "CAD";
            this.btnFromCAD.UseVisualStyleBackColor = true;
            this.btnFromCAD.Click += new System.EventHandler(this.from_click);
            // 
            // btnFromUSD
            // 
            this.btnFromUSD.AutoSize = true;
            this.btnFromUSD.Location = new System.Drawing.Point(12, 67);
            this.btnFromUSD.Name = "btnFromUSD";
            this.btnFromUSD.Size = new System.Drawing.Size(58, 20);
            this.btnFromUSD.TabIndex = 5;
            this.btnFromUSD.TabStop = true;
            this.btnFromUSD.Text = "USD";
            this.btnFromUSD.UseVisualStyleBackColor = true;
            this.btnFromUSD.Click += new System.EventHandler(this.from_click);
            // 
            // btnFromEUR
            // 
            this.btnFromEUR.AutoSize = true;
            this.btnFromEUR.Location = new System.Drawing.Point(11, 99);
            this.btnFromEUR.Name = "btnFromEUR";
            this.btnFromEUR.Size = new System.Drawing.Size(58, 20);
            this.btnFromEUR.TabIndex = 6;
            this.btnFromEUR.TabStop = true;
            this.btnFromEUR.Text = "EUR";
            this.btnFromEUR.UseVisualStyleBackColor = true;
            this.btnFromEUR.Click += new System.EventHandler(this.from_click);
            // 
            // btnFromGBP
            // 
            this.btnFromGBP.AutoSize = true;
            this.btnFromGBP.Location = new System.Drawing.Point(12, 132);
            this.btnFromGBP.Name = "btnFromGBP";
            this.btnFromGBP.Size = new System.Drawing.Size(57, 20);
            this.btnFromGBP.TabIndex = 7;
            this.btnFromGBP.TabStop = true;
            this.btnFromGBP.Text = "GBP";
            this.btnFromGBP.UseVisualStyleBackColor = true;
            this.btnFromGBP.Click += new System.EventHandler(this.from_click);
            // 
            // textboxfrom
            // 
            this.textboxfrom.Location = new System.Drawing.Point(23, 191);
            this.textboxfrom.Name = "textboxfrom";
            this.textboxfrom.Size = new System.Drawing.Size(100, 20);
            this.textboxfrom.TabIndex = 12;
            // 
            // textboxto
            // 
            this.textboxto.Location = new System.Drawing.Point(207, 191);
            this.textboxto.Name = "textboxto";
            this.textboxto.ReadOnly = true;
            this.textboxto.Size = new System.Drawing.Size(100, 20);
            this.textboxto.TabIndex = 13;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(23, 228);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 33);
            this.Convert.TabIndex = 14;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnToGBP
            // 
            this.btnToGBP.AutoSize = true;
            this.btnToGBP.Location = new System.Drawing.Point(6, 130);
            this.btnToGBP.Name = "btnToGBP";
            this.btnToGBP.Size = new System.Drawing.Size(57, 20);
            this.btnToGBP.TabIndex = 22;
            this.btnToGBP.TabStop = true;
            this.btnToGBP.Text = "GBP";
            this.btnToGBP.UseVisualStyleBackColor = true;
            this.btnToGBP.Click += new System.EventHandler(this.to_check);
            // 
            // btnToEUR
            // 
            this.btnToEUR.AutoSize = true;
            this.btnToEUR.Location = new System.Drawing.Point(6, 97);
            this.btnToEUR.Name = "btnToEUR";
            this.btnToEUR.Size = new System.Drawing.Size(58, 20);
            this.btnToEUR.TabIndex = 21;
            this.btnToEUR.TabStop = true;
            this.btnToEUR.Text = "EUR";
            this.btnToEUR.UseVisualStyleBackColor = true;
            this.btnToEUR.Click += new System.EventHandler(this.to_check);
            // 
            // btnToUSD
            // 
            this.btnToUSD.AutoSize = true;
            this.btnToUSD.Location = new System.Drawing.Point(6, 65);
            this.btnToUSD.Name = "btnToUSD";
            this.btnToUSD.Size = new System.Drawing.Size(58, 20);
            this.btnToUSD.TabIndex = 20;
            this.btnToUSD.TabStop = true;
            this.btnToUSD.Text = "USD";
            this.btnToUSD.UseVisualStyleBackColor = true;
            this.btnToUSD.Click += new System.EventHandler(this.to_check);
            // 
            // btnToCAD
            // 
            this.btnToCAD.AutoSize = true;
            this.btnToCAD.Location = new System.Drawing.Point(7, 31);
            this.btnToCAD.Name = "btnToCAD";
            this.btnToCAD.Size = new System.Drawing.Size(57, 20);
            this.btnToCAD.TabIndex = 19;
            this.btnToCAD.TabStop = true;
            this.btnToCAD.Text = "CAD";
            this.btnToCAD.UseVisualStyleBackColor = true;
            this.btnToCAD.Click += new System.EventHandler(this.to_check);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFromCAD);
            this.groupBox1.Controls.Add(this.btnFromGBP);
            this.groupBox1.Controls.Add(this.btnFromUSD);
            this.groupBox1.Controls.Add(this.btnFromEUR);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 166);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnToGBP);
            this.groupBox2.Controls.Add(this.btnToCAD);
            this.groupBox2.Controls.Add(this.btnToUSD);
            this.groupBox2.Controls.Add(this.btnToEUR);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(207, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 166);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MoneyEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.textboxto);
            this.Controls.Add(this.textboxfrom);
            this.Name = "MoneyEx";
            this.Text = "MoneyEx-ghazar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnFromCAD;
        private System.Windows.Forms.RadioButton btnFromUSD;
        private System.Windows.Forms.RadioButton btnFromEUR;
        private System.Windows.Forms.RadioButton btnFromGBP;
        private System.Windows.Forms.TextBox textboxfrom;
        private System.Windows.Forms.TextBox textboxto;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton btnToGBP;
        private System.Windows.Forms.RadioButton btnToEUR;
        private System.Windows.Forms.RadioButton btnToUSD;
        private System.Windows.Forms.RadioButton btnToCAD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}