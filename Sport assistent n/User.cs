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
    /// <summary>
    /// Исходный UserControl, который наследуется всеми контролами пользователей
    /// Client, Accountent и т.д.)
    /// </summary>
    public partial class User : UserControl
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
