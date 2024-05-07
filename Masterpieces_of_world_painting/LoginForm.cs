using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masterpieces_of_world_painting
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 40);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginField.Text.ToString() == "Admin")
            {
                if (passField.Text.ToString() == "1")
                {
                    Form admenu = new MenuAdmin();
                    admenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка! Введите другой логин или пароль.");
                }
            }
            if (loginField.Text.ToString() == "User")
            {
                if (passField.Text.ToString() == "0")
                {
                    Form usmenu = new MenuUser();
                    usmenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка! Введите другой логин или пароль.");
                }
            }
         }

        

        
    }
}
