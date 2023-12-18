using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_assistent_n
{
    //Исходный UserControl, который наследуется всеми контролами пользователей
    //(Client, Accountent и т. д.)
    public partial class User : UserControl
    {
        //Конструктор.
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
