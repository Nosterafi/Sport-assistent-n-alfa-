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
    //Кнопка, при нажатии на которую происходит переход в раздел входа систему.
    public partial class ExitButton : UserControl
    {
        //Конструктор.
        public ExitButton()
        {
            InitializeComponent();
        }

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.
        private void button1_Click(object sender, EventArgs e)
        {
            VisualEffects.Clear();
            var entry = new Entry
            {
                Location = new Point(290, 160),
                Anchor = AnchorStyles.None
            };
            VisualEffects.ActualForm.Controls.Add(entry);
        }
    }
}
