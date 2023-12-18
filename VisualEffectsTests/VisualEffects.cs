using Sport_assistent_n;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualEffectsTests
{
    //Класс-двойник Sport_Assistent_n.VisualEffects. Используется в тестах.
    public static class VisualEffects
    {
        //Форма, в которой происходят все действия
        private static Form actualForm;

        public static Form ActualForm
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
            ControlsChange(oldControl, newControl, oldControl.Location);
        }

        //Перегрузка метода, находящегося над этим комментарием. Убирает oldControl и ставит newControl на координатах newLocation
        public static void ControlsChange(UserControl oldControl, UserControl newControl, Point newLocation)
        {
            if (oldControl == null || newControl == null || newLocation == null)
                throw new NullReferenceException("Ни один из аргументов не может равняться null-у");
            newControl.Location = newLocation;
            newControl.Anchor = AnchorStyles.None;
            ActualForm.Controls.Clear();
            ActualForm.Controls.Add(newControl);
            newControl.Anchor = AnchorStyles.None;
        }

        //HideControls скрывает все элементы массива userControls
        public static void HideControls(UserControl[] userControls)
        {
            if (userControls == null)
                throw new NullReferenceException("userControls не может равняться null-у");
            foreach (var contr in userControls)
            {
                contr.Hide();
            }
        }

        //Clear удаляет все элементы с текущей формы
        public static void Clear() { ActualForm.Controls.Clear(); }

        //Этот метод отменяет изменения, внесёные в поле actualForm.
        public static void CancelChanged()
        {
            actualForm = null;
        }
    }
}
