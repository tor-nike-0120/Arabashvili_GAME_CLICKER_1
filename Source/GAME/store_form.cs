using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace GAME
{
    public partial class store_form : Form
    {
        public store_form()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source = player_info.db;");

        private void store_form_Load(object sender, EventArgs e)
        {
            string query_money = "SELECT money FROM player_info";
            string query_skin = "SELECT skin FROM player_info";
            string query_br = "SELECT bronze FROM player_info";
            string query_sl = "SELECT silver FROM player_info";
            string query_go = "SELECT gold FROM player_info";
            string query_di = "SELECT diamond FROM player_info";

            conn.Open();
            SQLiteCommand cmd_m = new SQLiteCommand(query_money, conn);
            SQLiteCommand cmd_s = new SQLiteCommand(query_skin, conn);
            SQLiteCommand cmd_b = new SQLiteCommand(query_br, conn);
            SQLiteCommand cmd_sl = new SQLiteCommand(query_sl, conn);
            SQLiteCommand cmd_g = new SQLiteCommand(query_go, conn);
            SQLiteCommand cmd_d = new SQLiteCommand(query_di, conn);

            money_label.Text = cmd_m.ExecuteScalar().ToString();
            skin_label.Text =  cmd_s.ExecuteScalar().ToString();
            bronze_s.Text = cmd_b.ExecuteScalar().ToString();
            silver_s.Text = cmd_sl.ExecuteScalar().ToString();
            gold_s.Text = cmd_g.ExecuteScalar().ToString();
            diamond_s.Text = cmd_d.ExecuteScalar().ToString();
            conn.Close();
            /*
            FileStream file = new FileStream(@"E:\УЧЕБА\2 КУРС\1 СЕМ\КУРСОВАЯ_2\GAME\files\info.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            money_label.Text = reader.ReadLine();
            skin_label.Text = reader.ReadLine();
            bronze_s.Text = reader.ReadLine();
            silver_s.Text = reader.ReadLine();
            gold_s.Text = reader.ReadLine();
            diamond_s.Text = reader.ReadLine();
            reader.Close();
            file.Close();
            */

            int x = Convert.ToInt32(money_label.Text);

            if (bronze_s.Text == "true")
            {
                if (skin_label.Text == "1")
                {
                    bronze_choose.Enabled = false;
                }
                bronze_buy.Enabled = false;
                bronze_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN1.png");
            }
            else
            {
                if (x < 1000)
                {
                    bronze_buy.Enabled = false;
                }
                bronze_choose.Enabled = false;
                bronze_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN_LOCK.png");
            }

            if (silver_s.Text == "true")
            {
                if (skin_label.Text == "2")
                {
                    silver_choose.Enabled = false;
                }
                silver_buy.Enabled = false;
                silver_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN2.png");
            }
            else
            {
                if (x < 10000)
                {
                    silver_buy.Enabled = false;
                }
                silver_choose.Enabled = false;
                silver_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN_LOCK.png");
            }

            if (gold_s.Text == "true")
            {
                if (skin_label.Text == "3")
                {
                    gold_choose.Enabled = false;
                }
                gold_buy.Enabled = false;
                gold_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN3.png");
            }
            else
            {
                if (x < 100000)
                {
                    gold_buy.Enabled = false;
                }
                gold_choose.Enabled = false;
                gold_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN_LOCK.png");
            }

            if (diamond_s.Text == "true")
            {
                if (skin_label.Text == "3")
                {
                    diamond_choose.Enabled = false;
                }
                diamond_buy.Enabled = false;
                diamond_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN4.png");
            }
            else
            {
                if (x < 1000000)
                {
                    diamond_buy.Enabled = false;
                }
                diamond_choose.Enabled = false;
                diamond_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN_LOCK.png");
            }

        }

        private void store_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "Update player_info Set money = @mo, skin = @sk, bronze = @br, silver = @si, gold = @go, diamond = @di";
            conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, conn);
            
            command.Parameters.Add("mo", DbType.String).Value = money_label.Text;
            command.Parameters.Add("sk", DbType.String).Value = skin_label.Text;
            command.Parameters.Add("br", DbType.String).Value = bronze_s.Text;
            command.Parameters.Add("si", DbType.String).Value = silver_s.Text;
            command.Parameters.Add("go", DbType.String).Value = gold_s.Text;
            command.Parameters.Add("di", DbType.String).Value = diamond_s.Text;
            command.ExecuteNonQuery();
            
            conn.Close();
            /*
            SQLiteCommand cmd_m = new SQLiteCommand(query_money, conn);
            SQLiteCommand cmd_s = new SQLiteCommand(query_skin, conn);
            SQLiteCommand cmd_b = new SQLiteCommand(query_br, conn);
            SQLiteCommand cmd_sl = new SQLiteCommand(query_sl, conn);
            SQLiteCommand cmd_g = new SQLiteCommand(query_go, conn);
            SQLiteCommand cmd_d = new SQLiteCommand(query_di, conn);
            
            FileStream file = new FileStream(@"E:\УЧЕБА\2 КУРС\1 СЕМ\КУРСОВАЯ_2\GAME\files\info.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(money_label.Text);
            writer.WriteLine(skin_label.Text);
            writer.WriteLine(bronze_s.Text);
            writer.WriteLine(silver_s.Text);
            writer.WriteLine(gold_s.Text);
            writer.WriteLine(diamond_s.Text);
            writer.Close();
            file.Close();
            */
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Update player_info Set money = @mo, skin = @sk, bronze = @br, silver = @si, gold = @go, diamond = @di";
            conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, conn);

            command.Parameters.Add("mo", DbType.String).Value = money_label.Text;
            command.Parameters.Add("sk", DbType.String).Value = skin_label.Text;
            command.Parameters.Add("br", DbType.String).Value = bronze_s.Text;
            command.Parameters.Add("si", DbType.String).Value = silver_s.Text;
            command.Parameters.Add("go", DbType.String).Value = gold_s.Text;
            command.Parameters.Add("di", DbType.String).Value = diamond_s.Text;
            command.ExecuteNonQuery();

            conn.Close();
            /*
            FileStream file = new FileStream(@"E:\УЧЕБА\2 КУРС\1 СЕМ\КУРСОВАЯ_2\GAME\files\info.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(money_label.Text);
            writer.WriteLine(skin_label.Text);
            writer.WriteLine(bronze_s.Text);
            writer.WriteLine(silver_s.Text);
            writer.WriteLine(gold_s.Text);
            writer.WriteLine(diamond_s.Text);
            writer.Close();
            file.Close();
            */

            menu_form menu_form = new menu_form();
            menu_form.Show();
            this.Hide();
        }

        private void bronze_buy_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(money_label.Text);

            x -= 1000;

            money_label.Text = Convert.ToString(x);
            bronze_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN1.png");
            bronze_s.Text = "true";
            skin_label.Text = "1";
            bronze_buy.Enabled = false;
        }

        private void skin_label_TextChanged(object sender, EventArgs e)
        {
            if (bronze_s.Text == "true")
            {
                bronze_choose.Enabled = true;
            }
            if (skin_label.Text == "1")
            {
                bronze_choose.Enabled = false;
            }

            if (silver_s.Text == "true")
            {
                silver_choose.Enabled = true;
            }
            if (skin_label.Text == "2")
            {
                silver_choose.Enabled = false;
            }

            if (gold_s.Text == "true")
            {
                gold_choose.Enabled = true;
            }
            if (skin_label.Text == "3")
            {
                gold_choose.Enabled = false;
            }

            if (diamond_s.Text == "true")
            {
                diamond_choose.Enabled = true;
            }
            if (skin_label.Text == "4")
            {
                diamond_choose.Enabled = false;
            }
        }

        private void bronze_choose_Click(object sender, EventArgs e)
        {
            skin_label.Text = "1";
        }

        private void silver_choose_Click(object sender, EventArgs e)
        {
            skin_label.Text = "2";
        }

        private void gold_choose_Click(object sender, EventArgs e)
        {
            skin_label.Text = "3";
        }

        private void diamond_choose_Click(object sender, EventArgs e)
        {
            skin_label.Text = "4";
        }

        private void silver_buy_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(money_label.Text);

            x -= 10000;

            money_label.Text = Convert.ToString(x);
            silver_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN2.png");
            silver_s.Text = "true";
            skin_label.Text = "2";
            silver_buy.Enabled = false;
        }

        private void gold_buy_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(money_label.Text);

            x -= 100000;

            money_label.Text = Convert.ToString(x);
            gold_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN3.png");
            gold_s.Text = "true";
            skin_label.Text = "3";
            gold_buy.Enabled = false;
        }

        private void diamond_buy_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(money_label.Text);

            x -= 1000000;

            money_label.Text = Convert.ToString(x);
            diamond_pict.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN4.png");
            diamond_s.Text = "true";
            skin_label.Text = "4";
            diamond_buy.Enabled = false;
        }
    }
}
