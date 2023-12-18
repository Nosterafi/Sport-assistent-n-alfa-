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
    //UserControl, который позволяет просматривать информацию о имеющихся абонементах
    //конкретного клиента и приобретать новые.
    public partial class Subscription : UserControl
    {
        public DataTable abonements;
        public DataTable section;
        //Конструктор.
        public Subscription()
        {
            InitializeComponent();
            ExLoad();
        }
        public void ExLoad()
        {
            dataGridView1.DataSource = abonements;
            dataGridView1.CellFormatting += DataGridViewSubscriptions_CellFormatting;
        }
        private void DataGridViewSubscriptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sections"].Index)
            {
                // Получите значение idSectiorn
                int idSection = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idSection"].Value);

                // Получите секции, связанные с абонементом
                var relatedSections = section.AsEnumerable()
                    .Where(row => row.Field<int>("id") == idSection)
                    .Select(row => row.Field<string>("SectionName"))
                    .ToList();

                // Форматируйте строку с секциями
                e.Value = string.Join(", ", relatedSections);
            }
        }

        //Все методы с именами, заканчивающимися на Click, отвечают
        //за действия, выполняемые при нажатии соответствующей кнопки.
        private void newSubscription_Click(object sender, EventArgs e)
        {

        }

        private void Subscription_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
