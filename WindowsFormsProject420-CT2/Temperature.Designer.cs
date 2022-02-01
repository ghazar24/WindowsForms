namespace WindowsFormsProject420_CT2
{
    partial class Temperature
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
            this.CtoF = new System.Windows.Forms.RadioButton();
            this.FtoC = new System.Windows.Forms.RadioButton();
            this.Ctextbox = new System.Windows.Forms.TextBox();
            this.Ftextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtoF.Location = new System.Drawing.Point(153, 12);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(105, 20);
            this.CtoF.TabIndex = 0;
            this.CtoF.TabStop = true;
            this.CtoF.Text = "From C to F";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.CheckedChanged += new System.EventHandler(this.CtoF_CheckedChanged);
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FtoC.Location = new System.Drawing.Point(153, 51);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(105, 20);
            this.FtoC.TabIndex = 1;
            this.FtoC.TabStop = true;
            this.FtoC.Text = "From F to C";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.CheckedChanged += new System.EventHandler(this.FtoC_CheckedChanged);
            // 
            // Ctextbox
            // 
            this.Ctextbox.Location = new System.Drawing.Point(66, 88);
            this.Ctextbox.Name = "Ctextbox";
            this.Ctextbox.Size = new System.Drawing.Size(100, 20);
            this.Ctextbox.TabIndex = 2;
            // 
            // Ftextbox
            // 
            this.Ftextbox.Location = new System.Drawing.Point(254, 87);
            this.Ftextbox.Name = "Ftextbox";
            this.Ftextbox.Size = new System.Drawing.Size(100, 20);
            this.Ftextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message:";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(30, 188);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(324, 64);
            this.Message.TabIndex = 7;
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(30, 269);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 8;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 318);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ftextbox);
            this.Controls.Add(this.Ctextbox);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.CtoF);
            this.Name = "Temperature";
            this.Text = "Temperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CtoF;
        private System.Windows.Forms.RadioButton FtoC;
        private System.Windows.Forms.TextBox Ctextbox;
        private System.Windows.Forms.TextBox Ftextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}