namespace vend
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.purchaseB = new System.Windows.Forms.Button();
            this.pennyI = new System.Windows.Forms.Button();
            this.nickelI = new System.Windows.Forms.Button();
            this.dimeI = new System.Windows.Forms.Button();
            this.quarterI = new System.Windows.Forms.Button();
            this.MUGROOTBEER = new System.Windows.Forms.Button();
            this.primeB = new System.Windows.Forms.Button();
            this.drpepperB = new System.Windows.Forms.Button();
            this.spriteB = new System.Windows.Forms.Button();
            this.cokeB = new System.Windows.Forms.Button();
            this.pepsiB = new System.Windows.Forms.Button();
            this.laysB = new System.Windows.Forms.Button();
            this.cheetoB = new System.Windows.Forms.Button();
            this.fritoB = new System.Windows.Forms.Button();
            this.doritoB = new System.Windows.Forms.Button();
            this.popcornerB = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.funyunB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(660, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(660, 157);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 16);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // purchaseB
            // 
            this.purchaseB.Location = new System.Drawing.Point(663, 176);
            this.purchaseB.Name = "purchaseB";
            this.purchaseB.Size = new System.Drawing.Size(91, 23);
            this.purchaseB.TabIndex = 15;
            this.purchaseB.Text = "Purchase";
            this.purchaseB.UseVisualStyleBackColor = true;
            this.purchaseB.Click += new System.EventHandler(this.purchaseB_Click);
            // 
            // pennyI
            // 
            this.pennyI.BackgroundImage = global::vend.Properties.Resources.images__3_1;
            this.pennyI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pennyI.Location = new System.Drawing.Point(349, 365);
            this.pennyI.Name = "pennyI";
            this.pennyI.Size = new System.Drawing.Size(76, 73);
            this.pennyI.TabIndex = 19;
            this.pennyI.Tag = "penny";
            this.pennyI.UseVisualStyleBackColor = true;
            this.pennyI.Click += new System.EventHandler(this.coin_Click);
            // 
            // nickelI
            // 
            this.nickelI.BackgroundImage = global::vend.Properties.Resources._1024px_Jefferson_Nickel_Unc_Obv;
            this.nickelI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nickelI.Location = new System.Drawing.Point(248, 353);
            this.nickelI.Name = "nickelI";
            this.nickelI.Size = new System.Drawing.Size(95, 85);
            this.nickelI.TabIndex = 18;
            this.nickelI.Tag = "nickel";
            this.nickelI.UseVisualStyleBackColor = true;
            this.nickelI.Click += new System.EventHandler(this.coin_Click);
            // 
            // dimeI
            // 
            this.dimeI.BackgroundImage = global::vend.Properties.Resources.Dime_Obverse_13;
            this.dimeI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dimeI.Location = new System.Drawing.Point(147, 353);
            this.dimeI.Name = "dimeI";
            this.dimeI.Size = new System.Drawing.Size(95, 85);
            this.dimeI.TabIndex = 17;
            this.dimeI.Tag = "dime";
            this.dimeI.UseVisualStyleBackColor = true;
            this.dimeI.Click += new System.EventHandler(this.coin_Click);
            // 
            // quarterI
            // 
            this.quarterI.BackgroundImage = global::vend.Properties.Resources._360_F_596061146_YLWhFwxPF57JneJxsUePzC8YVLnroYgh;
            this.quarterI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quarterI.Location = new System.Drawing.Point(12, 332);
            this.quarterI.Name = "quarterI";
            this.quarterI.Size = new System.Drawing.Size(128, 106);
            this.quarterI.TabIndex = 16;
            this.quarterI.Tag = "quarter";
            this.quarterI.UseVisualStyleBackColor = true;
            this.quarterI.Click += new System.EventHandler(this.coin_Click);
            // 
            // MUGROOTBEER
            // 
            this.MUGROOTBEER.BackgroundImage = global::vend.Properties.Resources._9375f38f03d06a5600ff64a98a83a753;
            this.MUGROOTBEER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MUGROOTBEER.Location = new System.Drawing.Point(336, 228);
            this.MUGROOTBEER.Name = "MUGROOTBEER";
            this.MUGROOTBEER.Size = new System.Drawing.Size(89, 87);
            this.MUGROOTBEER.TabIndex = 14;
            this.MUGROOTBEER.Tag = "10.00";
            this.MUGROOTBEER.Text = "MUG ROOT BEER!!!";
            this.MUGROOTBEER.UseVisualStyleBackColor = true;
            this.MUGROOTBEER.Click += new System.EventHandler(this.product_Click);
            // 
            // primeB
            // 
            this.primeB.BackgroundImage = global::vend.Properties.Resources.images__8_;
            this.primeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.primeB.Location = new System.Drawing.Point(336, 135);
            this.primeB.Name = "primeB";
            this.primeB.Size = new System.Drawing.Size(89, 87);
            this.primeB.TabIndex = 13;
            this.primeB.Tag = "0.05";
            this.primeB.Text = "Prime";
            this.primeB.UseVisualStyleBackColor = true;
            this.primeB.Click += new System.EventHandler(this.product_Click);
            // 
            // drpepperB
            // 
            this.drpepperB.BackgroundImage = global::vend.Properties.Resources._2469__23972;
            this.drpepperB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drpepperB.Location = new System.Drawing.Point(336, 42);
            this.drpepperB.Name = "drpepperB";
            this.drpepperB.Size = new System.Drawing.Size(89, 87);
            this.drpepperB.TabIndex = 12;
            this.drpepperB.Tag = "1.75";
            this.drpepperB.Text = "Dr. Pepper";
            this.drpepperB.UseVisualStyleBackColor = true;
            this.drpepperB.Click += new System.EventHandler(this.product_Click);
            // 
            // spriteB
            // 
            this.spriteB.BackgroundImage = global::vend.Properties.Resources.images__9_;
            this.spriteB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spriteB.Location = new System.Drawing.Point(241, 228);
            this.spriteB.Name = "spriteB";
            this.spriteB.Size = new System.Drawing.Size(89, 87);
            this.spriteB.TabIndex = 11;
            this.spriteB.Tag = "1.50";
            this.spriteB.Text = "Sprite";
            this.spriteB.UseVisualStyleBackColor = true;
            this.spriteB.Click += new System.EventHandler(this.product_Click);
            // 
            // cokeB
            // 
            this.cokeB.BackgroundImage = global::vend.Properties.Resources.images__7_;
            this.cokeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cokeB.Location = new System.Drawing.Point(241, 135);
            this.cokeB.Name = "cokeB";
            this.cokeB.Size = new System.Drawing.Size(89, 87);
            this.cokeB.TabIndex = 10;
            this.cokeB.Tag = "1.50";
            this.cokeB.Text = "Coca Cola";
            this.cokeB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cokeB.UseVisualStyleBackColor = true;
            this.cokeB.Click += new System.EventHandler(this.product_Click);
            // 
            // pepsiB
            // 
            this.pepsiB.BackgroundImage = global::vend.Properties.Resources.images__6_;
            this.pepsiB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pepsiB.Location = new System.Drawing.Point(241, 42);
            this.pepsiB.Name = "pepsiB";
            this.pepsiB.Size = new System.Drawing.Size(89, 87);
            this.pepsiB.TabIndex = 9;
            this.pepsiB.Tag = "2.15";
            this.pepsiB.Text = "Pepsi";
            this.pepsiB.UseVisualStyleBackColor = true;
            this.pepsiB.Click += new System.EventHandler(this.product_Click);
            // 
            // laysB
            // 
            this.laysB.BackgroundImage = global::vend.Properties.Resources.images__5_;
            this.laysB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.laysB.Location = new System.Drawing.Point(117, 228);
            this.laysB.Name = "laysB";
            this.laysB.Size = new System.Drawing.Size(89, 87);
            this.laysB.TabIndex = 8;
            this.laysB.Tag = "1.00";
            this.laysB.Text = "Lays";
            this.laysB.UseVisualStyleBackColor = true;
            this.laysB.Click += new System.EventHandler(this.product_Click);
            // 
            // cheetoB
            // 
            this.cheetoB.BackgroundImage = global::vend.Properties.Resources._81YKWD4qEfS__AC_UF894_1000_QL80_;
            this.cheetoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cheetoB.Location = new System.Drawing.Point(117, 135);
            this.cheetoB.Name = "cheetoB";
            this.cheetoB.Size = new System.Drawing.Size(89, 87);
            this.cheetoB.TabIndex = 7;
            this.cheetoB.Tag = "1.15";
            this.cheetoB.Text = "Baked Hot Cheetos";
            this.cheetoB.UseVisualStyleBackColor = true;
            this.cheetoB.Click += new System.EventHandler(this.product_Click);
            // 
            // fritoB
            // 
            this.fritoB.BackgroundImage = global::vend.Properties.Resources._91Xnq3ur84L__AC_UF894_1000_QL80_;
            this.fritoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fritoB.Location = new System.Drawing.Point(117, 42);
            this.fritoB.Name = "fritoB";
            this.fritoB.Size = new System.Drawing.Size(89, 87);
            this.fritoB.TabIndex = 6;
            this.fritoB.Tag = "1.25";
            this.fritoB.Text = "Fritos";
            this.fritoB.UseVisualStyleBackColor = true;
            this.fritoB.Click += new System.EventHandler(this.product_Click);
            // 
            // doritoB
            // 
            this.doritoB.BackgroundImage = global::vend.Properties.Resources.images__4_;
            this.doritoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doritoB.Location = new System.Drawing.Point(22, 228);
            this.doritoB.Name = "doritoB";
            this.doritoB.Size = new System.Drawing.Size(89, 87);
            this.doritoB.TabIndex = 5;
            this.doritoB.Tag = "1.50";
            this.doritoB.Text = "Doritos";
            this.doritoB.UseVisualStyleBackColor = true;
            this.doritoB.Click += new System.EventHandler(this.product_Click);
            // 
            // popcornerB
            // 
            this.popcornerB.BackgroundImage = global::vend.Properties.Resources.images__3_;
            this.popcornerB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.popcornerB.Location = new System.Drawing.Point(22, 135);
            this.popcornerB.Name = "popcornerB";
            this.popcornerB.Size = new System.Drawing.Size(89, 87);
            this.popcornerB.TabIndex = 4;
            this.popcornerB.Tag = "2.00";
            this.popcornerB.Text = "Pop Corners";
            this.popcornerB.UseVisualStyleBackColor = true;
            this.popcornerB.Click += new System.EventHandler(this.product_Click);
            // 
            // productImage
            // 
            this.productImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productImage.Location = new System.Drawing.Point(663, 12);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(125, 126);
            this.productImage.TabIndex = 3;
            this.productImage.TabStop = false;
            // 
            // funyunB
            // 
            this.funyunB.BackgroundImage = global::vend.Properties.Resources._91zYyU9bWDL;
            this.funyunB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.funyunB.Location = new System.Drawing.Point(22, 42);
            this.funyunB.Name = "funyunB";
            this.funyunB.Size = new System.Drawing.Size(89, 87);
            this.funyunB.TabIndex = 0;
            this.funyunB.Tag = "1.50";
            this.funyunB.Text = "Funyuns";
            this.funyunB.UseVisualStyleBackColor = true;
            this.funyunB.Click += new System.EventHandler(this.product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "$";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.moneyLabel.Location = new System.Drawing.Point(27, 12);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(18, 20);
            this.moneyLabel.TabIndex = 21;
            this.moneyLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pennyI);
            this.Controls.Add(this.nickelI);
            this.Controls.Add(this.dimeI);
            this.Controls.Add(this.quarterI);
            this.Controls.Add(this.purchaseB);
            this.Controls.Add(this.MUGROOTBEER);
            this.Controls.Add(this.primeB);
            this.Controls.Add(this.drpepperB);
            this.Controls.Add(this.spriteB);
            this.Controls.Add(this.cokeB);
            this.Controls.Add(this.pepsiB);
            this.Controls.Add(this.laysB);
            this.Controls.Add(this.cheetoB);
            this.Controls.Add(this.fritoB);
            this.Controls.Add(this.doritoB);
            this.Controls.Add(this.popcornerB);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.funyunB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button funyunB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Button popcornerB;
        private System.Windows.Forms.Button doritoB;
        private System.Windows.Forms.Button fritoB;
        private System.Windows.Forms.Button cheetoB;
        private System.Windows.Forms.Button laysB;
        private System.Windows.Forms.Button MUGROOTBEER;
        private System.Windows.Forms.Button primeB;
        private System.Windows.Forms.Button drpepperB;
        private System.Windows.Forms.Button spriteB;
        private System.Windows.Forms.Button cokeB;
        private System.Windows.Forms.Button pepsiB;
        private System.Windows.Forms.Button purchaseB;
        private System.Windows.Forms.Button quarterI;
        private System.Windows.Forms.Button dimeI;
        private System.Windows.Forms.Button nickelI;
        private System.Windows.Forms.Button pennyI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyLabel;
    }
}

