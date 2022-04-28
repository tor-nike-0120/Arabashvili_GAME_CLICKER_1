
namespace GAME
{
    partial class store_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.skin_label = new System.Windows.Forms.Label();
            this.bronze_pict = new System.Windows.Forms.PictureBox();
            this.bronze_buy = new System.Windows.Forms.Button();
            this.bronze_choose = new System.Windows.Forms.Button();
            this.bronze_discr = new System.Windows.Forms.Label();
            this.bronze_s = new System.Windows.Forms.Label();
            this.money_label = new System.Windows.Forms.Label();
            this.silver_s = new System.Windows.Forms.Label();
            this.silver_discr = new System.Windows.Forms.Label();
            this.silver_choose = new System.Windows.Forms.Button();
            this.silver_buy = new System.Windows.Forms.Button();
            this.silver_pict = new System.Windows.Forms.PictureBox();
            this.gold_s = new System.Windows.Forms.Label();
            this.gold_discr = new System.Windows.Forms.Label();
            this.gold_choose = new System.Windows.Forms.Button();
            this.gold_buy = new System.Windows.Forms.Button();
            this.gold_pict = new System.Windows.Forms.PictureBox();
            this.diamond_s = new System.Windows.Forms.Label();
            this.diamond_discr = new System.Windows.Forms.Label();
            this.diamond_choose = new System.Windows.Forms.Button();
            this.diamond_buy = new System.Windows.Forms.Button();
            this.diamond_pict = new System.Windows.Forms.PictureBox();
            this.bronze_price = new System.Windows.Forms.Label();
            this.silver_price = new System.Windows.Forms.Label();
            this.gold_price = new System.Windows.Forms.Label();
            this.diamond_price = new System.Windows.Forms.Label();
            this.part1_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bronze_pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver_pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gold_pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond_pict)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pixel Font7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "СЧЁТ:";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_button.FlatAppearance.BorderSize = 2;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(234)))));
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Pixel Font7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(572, 419);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(200, 30);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "ВЫХОД В МЕНЮ";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // skin_label
            // 
            this.skin_label.AutoSize = true;
            this.skin_label.Location = new System.Drawing.Point(87, 32);
            this.skin_label.Name = "skin_label";
            this.skin_label.Size = new System.Drawing.Size(38, 15);
            this.skin_label.TabIndex = 7;
            this.skin_label.Text = "label3";
            this.skin_label.Visible = false;
            this.skin_label.TextChanged += new System.EventHandler(this.skin_label_TextChanged);
            // 
            // bronze_pict
            // 
            this.bronze_pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bronze_pict.Location = new System.Drawing.Point(23, 124);
            this.bronze_pict.Name = "bronze_pict";
            this.bronze_pict.Size = new System.Drawing.Size(170, 170);
            this.bronze_pict.TabIndex = 8;
            this.bronze_pict.TabStop = false;
            // 
            // bronze_buy
            // 
            this.bronze_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bronze_buy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bronze_buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bronze_buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bronze_buy.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bronze_buy.Location = new System.Drawing.Point(23, 330);
            this.bronze_buy.Name = "bronze_buy";
            this.bronze_buy.Size = new System.Drawing.Size(75, 23);
            this.bronze_buy.TabIndex = 9;
            this.bronze_buy.Text = "КУПИТЬ";
            this.bronze_buy.UseVisualStyleBackColor = false;
            this.bronze_buy.Click += new System.EventHandler(this.bronze_buy_Click);
            // 
            // bronze_choose
            // 
            this.bronze_choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bronze_choose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bronze_choose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bronze_choose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bronze_choose.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bronze_choose.Location = new System.Drawing.Point(118, 330);
            this.bronze_choose.Name = "bronze_choose";
            this.bronze_choose.Size = new System.Drawing.Size(75, 23);
            this.bronze_choose.TabIndex = 10;
            this.bronze_choose.Text = "ВЫБОР";
            this.bronze_choose.UseVisualStyleBackColor = false;
            this.bronze_choose.Click += new System.EventHandler(this.bronze_choose_Click);
            // 
            // bronze_discr
            // 
            this.bronze_discr.AutoSize = true;
            this.bronze_discr.Location = new System.Drawing.Point(44, 297);
            this.bronze_discr.Name = "bronze_discr";
            this.bronze_discr.Size = new System.Drawing.Size(129, 30);
            this.bronze_discr.TabIndex = 11;
            this.bronze_discr.Text = "БРОНЗОВАЯ МОНЕТА\r\n1 КЛИК = 1 $";
            this.bronze_discr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bronze_s
            // 
            this.bronze_s.AutoSize = true;
            this.bronze_s.Location = new System.Drawing.Point(87, 199);
            this.bronze_s.Name = "bronze_s";
            this.bronze_s.Size = new System.Drawing.Size(38, 15);
            this.bronze_s.TabIndex = 12;
            this.bronze_s.Text = "label3";
            this.bronze_s.Visible = false;
            // 
            // money_label
            // 
            this.money_label.AutoSize = true;
            this.money_label.Font = new System.Drawing.Font("Pixel Font7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.money_label.Location = new System.Drawing.Point(411, 27);
            this.money_label.Name = "money_label";
            this.money_label.Size = new System.Drawing.Size(81, 24);
            this.money_label.TabIndex = 13;
            this.money_label.Text = "label2";
            // 
            // silver_s
            // 
            this.silver_s.AutoSize = true;
            this.silver_s.Location = new System.Drawing.Point(271, 199);
            this.silver_s.Name = "silver_s";
            this.silver_s.Size = new System.Drawing.Size(38, 15);
            this.silver_s.TabIndex = 18;
            this.silver_s.Text = "label3";
            this.silver_s.Visible = false;
            // 
            // silver_discr
            // 
            this.silver_discr.AutoSize = true;
            this.silver_discr.Location = new System.Drawing.Point(238, 297);
            this.silver_discr.Name = "silver_discr";
            this.silver_discr.Size = new System.Drawing.Size(131, 30);
            this.silver_discr.TabIndex = 17;
            this.silver_discr.Text = "СЕРЕБРЯНАЯ МОНЕТА\r\n1 КЛИК = 100 $";
            this.silver_discr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // silver_choose
            // 
            this.silver_choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.silver_choose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.silver_choose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.silver_choose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.silver_choose.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.silver_choose.Location = new System.Drawing.Point(312, 330);
            this.silver_choose.Name = "silver_choose";
            this.silver_choose.Size = new System.Drawing.Size(75, 23);
            this.silver_choose.TabIndex = 16;
            this.silver_choose.Text = "ВЫБОР";
            this.silver_choose.UseVisualStyleBackColor = false;
            this.silver_choose.Click += new System.EventHandler(this.silver_choose_Click);
            // 
            // silver_buy
            // 
            this.silver_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.silver_buy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.silver_buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.silver_buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.silver_buy.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.silver_buy.Location = new System.Drawing.Point(217, 330);
            this.silver_buy.Name = "silver_buy";
            this.silver_buy.Size = new System.Drawing.Size(75, 23);
            this.silver_buy.TabIndex = 15;
            this.silver_buy.Text = "КУПИТЬ";
            this.silver_buy.UseVisualStyleBackColor = false;
            this.silver_buy.Click += new System.EventHandler(this.silver_buy_Click);
            // 
            // silver_pict
            // 
            this.silver_pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.silver_pict.Location = new System.Drawing.Point(218, 124);
            this.silver_pict.Name = "silver_pict";
            this.silver_pict.Size = new System.Drawing.Size(170, 170);
            this.silver_pict.TabIndex = 14;
            this.silver_pict.TabStop = false;
            // 
            // gold_s
            // 
            this.gold_s.AutoSize = true;
            this.gold_s.Location = new System.Drawing.Point(469, 199);
            this.gold_s.Name = "gold_s";
            this.gold_s.Size = new System.Drawing.Size(38, 15);
            this.gold_s.TabIndex = 23;
            this.gold_s.Text = "label3";
            this.gold_s.Visible = false;
            // 
            // gold_discr
            // 
            this.gold_discr.AutoSize = true;
            this.gold_discr.Location = new System.Drawing.Point(432, 297);
            this.gold_discr.Name = "gold_discr";
            this.gold_discr.Size = new System.Drawing.Size(113, 30);
            this.gold_discr.TabIndex = 22;
            this.gold_discr.Text = "ЗОЛОТАЯ МОНЕТА\r\n1 КЛИК = 1000 $";
            this.gold_discr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gold_choose
            // 
            this.gold_choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gold_choose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gold_choose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.gold_choose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gold_choose.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gold_choose.Location = new System.Drawing.Point(506, 330);
            this.gold_choose.Name = "gold_choose";
            this.gold_choose.Size = new System.Drawing.Size(75, 23);
            this.gold_choose.TabIndex = 21;
            this.gold_choose.Text = "ВЫБОР";
            this.gold_choose.UseVisualStyleBackColor = false;
            this.gold_choose.Click += new System.EventHandler(this.gold_choose_Click);
            // 
            // gold_buy
            // 
            this.gold_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gold_buy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gold_buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.gold_buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gold_buy.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gold_buy.Location = new System.Drawing.Point(411, 330);
            this.gold_buy.Name = "gold_buy";
            this.gold_buy.Size = new System.Drawing.Size(75, 23);
            this.gold_buy.TabIndex = 20;
            this.gold_buy.Text = "КУПИТЬ";
            this.gold_buy.UseVisualStyleBackColor = false;
            this.gold_buy.Click += new System.EventHandler(this.gold_buy_Click);
            // 
            // gold_pict
            // 
            this.gold_pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gold_pict.Location = new System.Drawing.Point(411, 124);
            this.gold_pict.Name = "gold_pict";
            this.gold_pict.Size = new System.Drawing.Size(170, 170);
            this.gold_pict.TabIndex = 19;
            this.gold_pict.TabStop = false;
            // 
            // diamond_s
            // 
            this.diamond_s.AutoSize = true;
            this.diamond_s.Location = new System.Drawing.Point(667, 199);
            this.diamond_s.Name = "diamond_s";
            this.diamond_s.Size = new System.Drawing.Size(38, 15);
            this.diamond_s.TabIndex = 28;
            this.diamond_s.Text = "label3";
            this.diamond_s.Visible = false;
            // 
            // diamond_discr
            // 
            this.diamond_discr.AutoSize = true;
            this.diamond_discr.Location = new System.Drawing.Point(624, 297);
            this.diamond_discr.Name = "diamond_discr";
            this.diamond_discr.Size = new System.Drawing.Size(125, 30);
            this.diamond_discr.TabIndex = 27;
            this.diamond_discr.Text = "АЛМАЗНАЯ МОНЕТА\r\n1 КЛИК = 10000 $";
            this.diamond_discr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diamond_choose
            // 
            this.diamond_choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.diamond_choose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.diamond_choose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.diamond_choose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.diamond_choose.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diamond_choose.Location = new System.Drawing.Point(698, 330);
            this.diamond_choose.Name = "diamond_choose";
            this.diamond_choose.Size = new System.Drawing.Size(75, 23);
            this.diamond_choose.TabIndex = 26;
            this.diamond_choose.Text = "ВЫБОР";
            this.diamond_choose.UseVisualStyleBackColor = false;
            this.diamond_choose.Click += new System.EventHandler(this.diamond_choose_Click);
            // 
            // diamond_buy
            // 
            this.diamond_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.diamond_buy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.diamond_buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.diamond_buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.diamond_buy.Font = new System.Drawing.Font("Pixel Font7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diamond_buy.Location = new System.Drawing.Point(603, 330);
            this.diamond_buy.Name = "diamond_buy";
            this.diamond_buy.Size = new System.Drawing.Size(75, 23);
            this.diamond_buy.TabIndex = 25;
            this.diamond_buy.Text = "КУПИТЬ";
            this.diamond_buy.UseVisualStyleBackColor = false;
            this.diamond_buy.Click += new System.EventHandler(this.diamond_buy_Click);
            // 
            // diamond_pict
            // 
            this.diamond_pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diamond_pict.Location = new System.Drawing.Point(601, 124);
            this.diamond_pict.Name = "diamond_pict";
            this.diamond_pict.Size = new System.Drawing.Size(170, 170);
            this.diamond_pict.TabIndex = 24;
            this.diamond_pict.TabStop = false;
            // 
            // bronze_price
            // 
            this.bronze_price.AutoSize = true;
            this.bronze_price.Font = new System.Drawing.Font("Pixel Font7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bronze_price.Location = new System.Drawing.Point(73, 105);
            this.bronze_price.Name = "bronze_price";
            this.bronze_price.Size = new System.Drawing.Size(71, 16);
            this.bronze_price.TabIndex = 29;
            this.bronze_price.Text = "1000 $";
            // 
            // silver_price
            // 
            this.silver_price.AutoSize = true;
            this.silver_price.Font = new System.Drawing.Font("Pixel Font7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.silver_price.Location = new System.Drawing.Point(262, 105);
            this.silver_price.Name = "silver_price";
            this.silver_price.Size = new System.Drawing.Size(83, 16);
            this.silver_price.TabIndex = 30;
            this.silver_price.Text = "10000 $";
            // 
            // gold_price
            // 
            this.gold_price.AutoSize = true;
            this.gold_price.Font = new System.Drawing.Font("Pixel Font7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gold_price.Location = new System.Drawing.Point(450, 105);
            this.gold_price.Name = "gold_price";
            this.gold_price.Size = new System.Drawing.Size(95, 16);
            this.gold_price.TabIndex = 31;
            this.gold_price.Text = "100000 $";
            // 
            // diamond_price
            // 
            this.diamond_price.AutoSize = true;
            this.diamond_price.Font = new System.Drawing.Font("Pixel Font7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diamond_price.Location = new System.Drawing.Point(633, 105);
            this.diamond_price.Name = "diamond_price";
            this.diamond_price.Size = new System.Drawing.Size(107, 16);
            this.diamond_price.TabIndex = 32;
            this.diamond_price.Text = "1000000 $";
            // 
            // part1_label
            // 
            this.part1_label.AutoSize = true;
            this.part1_label.Font = new System.Drawing.Font("Pixel Font7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.part1_label.Location = new System.Drawing.Point(23, 68);
            this.part1_label.Name = "part1_label";
            this.part1_label.Size = new System.Drawing.Size(141, 18);
            this.part1_label.TabIndex = 33;
            this.part1_label.Text = "ВНЕШНИЙ ВИД";
            // 
            // store_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(225)))), ((int)(((byte)(197)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.part1_label);
            this.Controls.Add(this.diamond_price);
            this.Controls.Add(this.gold_price);
            this.Controls.Add(this.silver_price);
            this.Controls.Add(this.bronze_price);
            this.Controls.Add(this.diamond_s);
            this.Controls.Add(this.diamond_discr);
            this.Controls.Add(this.diamond_choose);
            this.Controls.Add(this.diamond_buy);
            this.Controls.Add(this.diamond_pict);
            this.Controls.Add(this.gold_s);
            this.Controls.Add(this.gold_discr);
            this.Controls.Add(this.gold_choose);
            this.Controls.Add(this.gold_buy);
            this.Controls.Add(this.gold_pict);
            this.Controls.Add(this.silver_s);
            this.Controls.Add(this.silver_discr);
            this.Controls.Add(this.silver_choose);
            this.Controls.Add(this.silver_buy);
            this.Controls.Add(this.silver_pict);
            this.Controls.Add(this.money_label);
            this.Controls.Add(this.bronze_s);
            this.Controls.Add(this.bronze_discr);
            this.Controls.Add(this.bronze_choose);
            this.Controls.Add(this.bronze_buy);
            this.Controls.Add(this.bronze_pict);
            this.Controls.Add(this.skin_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.Name = "store_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БАЛДЕЖНЫЙ КЛИКЕР";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.store_form_FormClosed);
            this.Load += new System.EventHandler(this.store_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bronze_pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver_pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gold_pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamond_pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label skin_label;
        private System.Windows.Forms.PictureBox bronze_pict;
        private System.Windows.Forms.Button bronze_buy;
        private System.Windows.Forms.Button bronze_choose;
        private System.Windows.Forms.Label bronze_discr;
        private System.Windows.Forms.Label bronze_s;
        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.Label silver_s;
        private System.Windows.Forms.Label silver_discr;
        private System.Windows.Forms.Button silver_choose;
        private System.Windows.Forms.Button silver_buy;
        private System.Windows.Forms.PictureBox silver_pict;
        private System.Windows.Forms.Label gold_s;
        private System.Windows.Forms.Label gold_discr;
        private System.Windows.Forms.Button gold_choose;
        private System.Windows.Forms.Button gold_buy;
        private System.Windows.Forms.PictureBox gold_pict;
        private System.Windows.Forms.Label diamond_s;
        private System.Windows.Forms.Label diamond_discr;
        private System.Windows.Forms.Button diamond_choose;
        private System.Windows.Forms.Button diamond_buy;
        private System.Windows.Forms.PictureBox diamond_pict;
        private System.Windows.Forms.Label bronze_price;
        private System.Windows.Forms.Label silver_price;
        private System.Windows.Forms.Label gold_price;
        private System.Windows.Forms.Label diamond_price;
        private System.Windows.Forms.Label part1_label;
    }
}