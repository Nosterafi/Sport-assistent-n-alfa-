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
    /// UserControl, который показывается в самом
    /// начале и содержит кнопку перехода к окну для входа в систему.
    /// Наследует UserControl
    /// </summary>
    public partial class Begin : UserControl
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        public Begin()
        {
            InitializeComponent();
        }
        //Все методы с именами, заканчивающимися на Click, отвечают за действия,
        //выполняемые при нажатии на соответствующие элементы

        /// <summary>
        /// Метод, запускающийся при нажатии кнопки beginButton и открывающий окно входа
        /// </summary>
        private void beginButton_Click(object sender, EventArgs e)
        {
            VisualEffects.ControlsChange(this, new Entry());
        }

        private void Begin_Load(object sender, EventArgs e)
        {

        }
    }
}
