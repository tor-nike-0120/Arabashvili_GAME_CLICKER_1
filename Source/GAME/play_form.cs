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
    public partial class play_form : Form
    {
        static string path = @"E:\УЧЕБА\2 КУРС\1 СЕМ\КУРСОВАЯ_2\GAME\files\info.txt";

        SQLiteConnection conn = new SQLiteConnection("Data Source = player_info.db;");

        public play_form()
        {
            InitializeComponent();

            string query_money = "SELECT money FROM player_info";
            string query_skin = "SELECT skin FROM player_info";

            conn.Open();
            SQLiteCommand cmd_m = new SQLiteCommand(query_money, conn);
            SQLiteCommand cmd_s = new SQLiteCommand(query_skin, conn);

            money.Text = cmd_m.ExecuteScalar().ToString();
            skin.Text = cmd_s.ExecuteScalar().ToString();

            conn.Close();

            /*
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            money.Text = reader.ReadLine();
            skin.Text = reader.ReadLine();
            reader.Close();
            file.Close();
            */
            coin.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN0.png");

            if (skin.Text == "1")
            {
                coin.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN1.png");
            }

            if (skin.Text == "2")
            {
                coin.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN2.png");
            }

            if (skin.Text == "3")
            {
                coin.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN3.png");
            }

            if (skin.Text == "4")
            {
                coin.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\img_курсач2\COIN4.png");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void play_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            string query = "Update player_info Set money = @mo, skin = @sk";
            conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, conn);

            command.Parameters.Add("mo", DbType.String).Value = money.Text;
            command.Parameters.Add("sk", DbType.String).Value = skin.Text;
            command.ExecuteNonQuery();

            conn.Close();

            /*
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(money.Text);
            writer.WriteLine(skin.Text);
            writer.Close();
            file.Close();
            */

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Update player_info Set money = @mo, skin = @sk";
            conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, conn);

            command.Parameters.Add("mo", DbType.String).Value = money.Text;
            command.Parameters.Add("sk", DbType.String).Value = skin.Text;
            command.ExecuteNonQuery();

            conn.Close();
            /*
            FileStream file = new FileStream(@"E:\УЧЕБА\2 КУРС\1 СЕМ\КУРСОВАЯ_2\GAME\files\info.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(money.Text);
            writer.WriteLine(skin.Text);
            writer.Close();
            file.Close();
            */

            menu_form menu_form = new menu_form();
            menu_form.Show();
            this.Hide();
        }

        private void play_form_Load(object sender, EventArgs e)
        {

        }

        private void coin_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(money.Text);
            if (skin.Text == "1" || skin.Text == "0")
            {
                x++;
            }
            if (skin.Text == "2")
            {
                x += 100;
            }
            if (skin.Text == "3")
            {
                x += 1000;
            }
            if (skin.Text == "4")
            {
                x += 10000;
            }
            money.Text = Convert.ToString(x);
        }
    }
}
