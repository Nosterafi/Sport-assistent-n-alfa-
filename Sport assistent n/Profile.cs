using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sport_assistent_n
{
    //UserControl, предоставляющий информацию о данных профиля пользователя.
    public partial class Profile : UserControl
    {
        //Конструктор.
        public Profile()
        {
            InitializeComponent();
        }

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.
        private void hideLogin_Click(object sender, EventArgs e)
        {
            userLogin.UseSystemPasswordChar = !userLogin.UseSystemPasswordChar;
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            userPassword.UseSystemPasswordChar = !userPassword.UseSystemPasswordChar;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
