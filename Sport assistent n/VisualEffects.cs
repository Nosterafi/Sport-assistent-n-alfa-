using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_assistent_n
{
    /// <summary>
    /// Статичексий класс VisualEffects отвечает за смену UserControl-ов в приложении
    /// </summary>
    public static class VisualEffects
    {
        /// <summary>
        /// Форма, в которой происходит вся работа
        /// </summary>
        private static MainForm actualForm;

        /// <summary>
        /// Свойство, контролирующее поле actualForm
        /// </summary>
        /// <params name="value">
        /// Новая форма, с которой будет работать приложение
        /// </params>
        /// <returns> 
        /// Текущая рабочая форма
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Выдаётся при попытке повторного присвоения значения
        /// </exception>
        public static MainForm ActualForm
        {
            get { return actualForm; }
            set
            {
                if (actualForm != null) throw new InvalidOperationException("Значение ActualForm нельзя изменять повторно");
                actualForm = value;
            }
        }
        
        /// <summary>
        /// Ставит один UserControl на место другого
        /// </summary>
        /// <param name="oldControl">UserControl, который нужно заменить</param>
        /// <param name="newControl">Новый UserControl</param>
        /// <exception cref="NullReferenceException">Выдаётся при попытке передать в метод null</exception>
        /// <exception cref="ArgumentException">
        /// Выдаётся, если указанного в качестве oldControla UserControl-а нет на рабочей форме в момент вызова
        /// </exception>
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

        /// <summary>
        /// Ставит новый UserControl в указанную точку, убирая при этом старый
        /// </summary>
        /// <param name="oldControl">UserControl, который нужно заменить</param>
        /// <param name="newControl">Новый UserControl</param>
        /// <param name="newLocation">Точка, в которую нужно поставить новый UserControl</param>
        /// <exception cref="NullReferenceException">Выдаётся при попытке передать в метод null</exception>
        /// <exception cref="ArgumentException">
        /// Выдаётся, если указанного в качестве oldControla UserControl-а нет на рабочей форме в момент вызова
        /// </exception>
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

        /// <summary>
        /// Скрывает UserControl-ы, переданные в виде массива
        /// </summary>
        /// <param name="userControls">Массив с UserControl-ами, которые нужно скрыть</param>
        public static void HideControls(UserControl[] userControls)
        {
            foreach(var contr in userControls)
            {
                contr.Hide();
            }
        }

        /// <summary>
        /// Удаляет все Control-ы с рабочей формы
        /// </summary>
        public static void Clear() { ActualForm.Controls.Clear(); } 
    }
}
