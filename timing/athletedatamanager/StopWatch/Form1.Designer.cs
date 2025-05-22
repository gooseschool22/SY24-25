namespace StopWatch
{
    partial class StopWatch
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
            this.components = new System.ComponentModel.Container();
            this.watchLabel = new System.Windows.Forms.Label();
            this.Startbutton1 = new System.Windows.Forms.Button();
            this.Stopbutton1 = new System.Windows.Forms.Button();
            this.Resetbutton1 = new System.Windows.Forms.Button();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // watchLabel
            // 
            this.watchLabel.AutoSize = true;
            this.watchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.watchLabel.Location = new System.Drawing.Point(318, 138);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(111, 29);
            this.watchLabel.TabIndex = 0;
            this.watchLabel.Text = "00:00.00";
            // 
            // Startbutton1
            // 
            this.Startbutton1.Location = new System.Drawing.Point(211, 186);
            this.Startbutton1.Name = "Startbutton1";
            this.Startbutton1.Size = new System.Drawing.Size(75, 54);
            this.Startbutton1.TabIndex = 1;
            this.Startbutton1.Text = "start";
            this.Startbutton1.UseVisualStyleBackColor = true;
            this.Startbutton1.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Stopbutton1
            // 
            this.Stopbutton1.Location = new System.Drawing.Point(336, 186);
            this.Stopbutton1.Name = "Stopbutton1";
            this.Stopbutton1.Size = new System.Drawing.Size(75, 54);
            this.Stopbutton1.TabIndex = 2;
            this.Stopbutton1.Text = "stop";
            this.Stopbutton1.UseVisualStyleBackColor = true;
            this.Stopbutton1.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // Resetbutton1
            // 
            this.Resetbutton1.Location = new System.Drawing.Point(454, 186);
            this.Resetbutton1.Name = "Resetbutton1";
            this.Resetbutton1.Size = new System.Drawing.Size(75, 54);
            this.Resetbutton1.TabIndex = 3;
            this.Resetbutton1.Text = "reset";
            this.Resetbutton1.UseVisualStyleBackColor = true;
            this.Resetbutton1.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // formTimer
            // 
            this.formTimer.Interval = 10;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resetbutton1);
            this.Controls.Add(this.Stopbutton1);
            this.Controls.Add(this.Startbutton1);
            this.Controls.Add(this.watchLabel);
            this.Name = "StopWatch";
            this.Text = "Stop Watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Button Startbutton1;
        private System.Windows.Forms.Button Stopbutton1;
        private System.Windows.Forms.Button Resetbutton1;
        private System.Windows.Forms.Timer formTimer;
    }
}

