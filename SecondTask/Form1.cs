/*Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
 *  (рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вашего окна; */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show(String.Format("Ширина - {0}, Высота - {1}", this.Height, this.Width));
            }
        }
    }
}
