using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_assistent_n
{
    //Этот класс отвечает за смену UserControl-ов в приложении
    public static class VisualEffects
    {
        //Форма, в которой происходят все действия
        private static MainForm actualForm;
        public static MainForm ActualForm
        {
            get { return actualForm; }
            set
            {
                if (actualForm != null) throw new InvalidOperationException("Значение ActualForm нельзя изменять повторно");
                actualForm = value;
            }
        }
        //void ControlsChange(UserControl oldControl, UserControl newControl) ставит на место oldControl новый элемент newControl
        public static void ControlsChange(UserControl oldControl, UserControl newControl)
        {
            if (oldControl == null || newControl == null)
                throw new NullReferenceException("Ни один из аргументов не может равняться null-у");
            try
            {
                newControl.Location = oldControl.Location;
                newControl.Anchor = AnchorStyles.None;
                ActualForm.Controls.Remove(oldControl);
                ActualForm.Controls.Add(newControl);
                oldControl.Hide();
            }
            catch { throw new ArgumentException("oldControl не найден"); }
            newControl.Anchor = AnchorStyles.None;
        }
        //Перегрузка метода, находящегося над этим комментарием. Убирает oldControl и ставит newControl на координатах newLocation
        public static void ControlsChange(UserControl oldControl, UserControl newControl, Point newLocation)
        {
            if (oldControl == null || newControl == null)
                throw new NullReferenceException("Ни один из аргументов не может равняться null-у");
            try
            {
                newControl.Location = newLocation;
                newControl.Anchor = AnchorStyles.None;
                ActualForm.Controls.Clear();
                ActualForm.Controls.Add(newControl);
            }
            catch { throw new ArgumentException("oldControl не найден"); }
            newControl.Anchor=AnchorStyles.None;
        }
        //HideControls скрывает все элементы массива userControls
        public static void HideControls(UserControl[] userControls)
        {
            foreach(var contr in userControls)
            {
                contr.Hide();
                //((Form)contr.TopLevelControl).Close();
            }
        }

        //Clear удаляет все элементы с текущей формы
        public static void Clear() { ActualForm.Controls.Clear(); } 
    }
}
