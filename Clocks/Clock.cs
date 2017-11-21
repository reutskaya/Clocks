using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clocks
{
    public partial class Clock : Form
    {
        /// <summary>
        /// Создаем объект "часы"
        /// </summary>
        public Clock()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод регулярно выводит на экран время в формате часы:минуты:секунды (24-часовой формат)
        /// </summary>
        /// <param name="sender">вызывает событие</param>
        /// <param name="e">обрадотчику не передается доп. информация</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// При клике меняется цвет шрифта на салатовый и появляется надпись "Do not click this!"
        /// </summary>
        /// <param name="sender">вызывает событие</param>
        /// <param name="e">обрадотчику не передается доп. информация</param>
        private void ClockTimer_Click(object sender, EventArgs e)
        {
            ClockTimer.ForeColor = Color.GreenYellow;
            ClockTimer.Text = "Do not click this!";
        }
        /// <summary>
        /// При двойном клике цвет становится чёрным
        /// </summary>
        /// <param name="sender">вызывает событие</param>
        /// <param name="e">обрадотчику не передается доп. информация</param>
        private void ClockTimer_DoubleClick(object sender, EventArgs e)
        {
            ClockTimer.ForeColor = Color.Black;
        }
    }
}
