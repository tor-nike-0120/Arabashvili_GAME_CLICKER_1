using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            play_form play_form = new play_form();
            this.Hide();
            play_form.Show();
        }

        private void store_button_Click(object sender, EventArgs e)
        {
            store_form store_form = new store_form();
            this.Hide();
            store_form.Show();
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            about_form about_form = new about_form();
            about_form.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
