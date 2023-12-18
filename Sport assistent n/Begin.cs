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
    //UserControl, который показывается в самом
    //начале и содержит кнопку перехода к UserControl-у для входа в систему.
    public partial class Begin : UserControl
    {
        //Конструктор
        public Begin()
        {
            InitializeComponent();
        }
        //Все методы с именами, заканчивающимися на Click, отвечают за действия,
        //выполняемые при нажатии на соответствующие элементы
        private void beginButton_Click(object sender, EventArgs e)
        {
            VisualEffects.ControlsChange(this, new Entry());
        }

        private void Begin_Load(object sender, EventArgs e)
        {

        }
    }
}
