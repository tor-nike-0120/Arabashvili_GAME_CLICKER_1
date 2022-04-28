
namespace GAME
{
    partial class play_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.skin = new System.Windows.Forms.Label();
            this.coin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(234)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Pixel Font7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(572, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "ВЫХОД В МЕНЮ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Pixel Font7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.money.Location = new System.Drawing.Point(357, 50);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(72, 24);
            this.money.TabIndex = 3;
            this.money.Text = "label1";
            // 
            // skin
            // 
            this.skin.AutoSize = true;
            this.skin.Location = new System.Drawing.Point(661, 50);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(38, 15);
            this.skin.TabIndex = 4;
            this.skin.Text = "label1";
            this.skin.Visible = false;
            // 
            // coin
            // 
            this.coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin.Location = new System.Drawing.Point(273, 106);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(240, 240);
            this.coin.TabIndex = 5;
            this.coin.UseVisualStyleBackColor = false;
            this.coin.Click += new System.EventHandler(this.coin_Click);
            // 
            // play_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(225)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.skin);
            this.Controls.Add(this.money);
            this.Controls.Add(this.button1);
            this.Name = "play_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БАЛДЕЖНЫЙ КЛИКЕР";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.play_form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label skin;
        private System.Windows.Forms.Button coin;
    }
}