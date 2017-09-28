/*■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна 
 * текущие координаты мыши x и y*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button==MouseButtons.Right)
                MessageBox.Show("", String.Format("{0}, {1}",Cursor.Position.X, Cursor.Position.Y));
        }
    }
}
