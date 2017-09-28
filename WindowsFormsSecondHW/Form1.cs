using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSecondHW
{
    public partial class Form1 : Form
    {
        bool clickedMouse=false;
        public Form1()
        {
            InitializeComponent();
        }
        
        /*■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка:
  вну- три прямоугольника, снаружи, на границе прямоугольника.*/
  // Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Cursor.Position.X>250 && Cursor.Position.Y>250) 
                MessageBox.Show(String.Format("{0}, {1} - точка вне границ прямоугольника",Cursor.Position.X.ToString(), Cursor.Position.Y.ToString()));
                else if (Cursor.Position.X < 250 && Cursor.Position.Y < 250)
                    MessageBox.Show(String.Format("{0}, {1} - точка в прямоугольнике", Cursor.Position.X.ToString(), Cursor.Position.Y.ToString()));
                else if (Cursor.Position.X == 250 && Cursor.Position.Y == 250)
                    MessageBox.Show(String.Format("{0}, {1} - точка на границе прямоугольника", Cursor.Position.X.ToString(), Cursor.Position.Y.ToString()));
                //clickedMouse = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && clickedMouse==true)
            this.Close();
        }
    }
}

