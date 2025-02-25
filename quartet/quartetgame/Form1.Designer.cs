namespace quartetgame
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
            this.carpic1 = new System.Windows.Forms.PictureBox();
            this.maxspeedT = new System.Windows.Forms.TextBox();
            this.zerotosixtyT = new System.Windows.Forms.TextBox();
            this.hpT = new System.Windows.Forms.TextBox();
            this.ccT = new System.Windows.Forms.TextBox();
            this.cylindersT = new System.Windows.Forms.TextBox();
            this.rpmT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.carpic1)).BeginInit();
            this.SuspendLayout();
            // 
            // carpic1
            // 
            this.carpic1.Location = new System.Drawing.Point(12, 12);
            this.carpic1.Name = "carpic1";
            this.carpic1.Size = new System.Drawing.Size(100, 98);
            this.carpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpic1.TabIndex = 0;
            this.carpic1.TabStop = false;
            // 
            // maxspeedT
            // 
            this.maxspeedT.Location = new System.Drawing.Point(12, 177);
            this.maxspeedT.Name = "maxspeedT";
            this.maxspeedT.ReadOnly = true;
            this.maxspeedT.Size = new System.Drawing.Size(100, 22);
            this.maxspeedT.TabIndex = 1;
            // 
            // zerotosixtyT
            // 
            this.zerotosixtyT.Location = new System.Drawing.Point(12, 219);
            this.zerotosixtyT.Name = "zerotosixtyT";
            this.zerotosixtyT.ReadOnly = true;
            this.zerotosixtyT.Size = new System.Drawing.Size(100, 22);
            this.zerotosixtyT.TabIndex = 2;
            // 
            // hpT
            // 
            this.hpT.Location = new System.Drawing.Point(12, 266);
            this.hpT.Name = "hpT";
            this.hpT.ReadOnly = true;
            this.hpT.Size = new System.Drawing.Size(100, 22);
            this.hpT.TabIndex = 3;
            // 
            // ccT
            // 
            this.ccT.Location = new System.Drawing.Point(12, 313);
            this.ccT.Name = "ccT";
            this.ccT.ReadOnly = true;
            this.ccT.Size = new System.Drawing.Size(100, 22);
            this.ccT.TabIndex = 4;
            // 
            // cylindersT
            // 
            this.cylindersT.Location = new System.Drawing.Point(12, 362);
            this.cylindersT.Name = "cylindersT";
            this.cylindersT.ReadOnly = true;
            this.cylindersT.Size = new System.Drawing.Size(100, 22);
            this.cylindersT.TabIndex = 5;
            // 
            // rpmT
            // 
            this.rpmT.Location = new System.Drawing.Point(12, 409);
            this.rpmT.Name = "rpmT";
            this.rpmT.ReadOnly = true;
            this.rpmT.Size = new System.Drawing.Size(100, 22);
            this.rpmT.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Maxspeed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zero to Sixty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "HP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cylinders:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "RPM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name:";
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(12, 133);
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Size = new System.Drawing.Size(181, 22);
            this.nameT.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rpmT);
            this.Controls.Add(this.cylindersT);
            this.Controls.Add(this.ccT);
            this.Controls.Add(this.hpT);
            this.Controls.Add(this.zerotosixtyT);
            this.Controls.Add(this.maxspeedT);
            this.Controls.Add(this.carpic1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carpic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carpic1;
        private System.Windows.Forms.TextBox maxspeedT;
        private System.Windows.Forms.TextBox zerotosixtyT;
        private System.Windows.Forms.TextBox hpT;
        private System.Windows.Forms.TextBox ccT;
        private System.Windows.Forms.TextBox cylindersT;
        private System.Windows.Forms.TextBox rpmT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameT;
    }
}

