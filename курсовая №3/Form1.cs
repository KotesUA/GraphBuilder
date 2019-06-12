using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace курсовая
{
    public partial class Form1 : Form
    {
        // создаем рабочую область рисунка
        Bitmap b2 = new Bitmap(780, 540);

        public Form1()
        {
            InitializeComponent();
        }

        // рисуем координатную плоскость
        public void Sis_coor()
        {
            // переменные проверки на чётность
            int chet = 2;
            int chet2 = 2;
            pictureBox1.BackColor = Color.White;
            Pen p = new Pen(Color.Black, 2);
            Graphics g1 = Graphics.FromImage(b2);
            for (int i = 0; i <= pictureBox1.Width; i += 20)
            {
                g1.DrawLine(Pens.Gray, i, 0, i, pictureBox1.Height);
                g1.DrawLine(p, i, pictureBox1.Height - pictureBox1.Height / 2 - 4, i, pictureBox1.Height - pictureBox1.Height / 2 + 4);
                if (chet2 % 2 == 0)
                {
                    g1.DrawString(Convert.ToString(-i / 40), new Font("Arial", 8), Brushes.Black, pictureBox1.Width / 2, pictureBox1.Height - pictureBox1.Height / 2 + i);      // подписи осей
                    g1.DrawString(Convert.ToString(i / 40), new Font("Arial", 8), Brushes.Black, pictureBox1.Width / 2, pictureBox1.Height - pictureBox1.Height / 2 - i);
                }
                chet2++;
            }
            // в цикле с шагом 20 пикелей рисуем прямые
            for (int j = 0; j <= pictureBox1.Height; j += 20)
            {
                g1.DrawLine(Pens.Gray, 0, j, pictureBox1.Width, j);
                g1.DrawLine(p, pictureBox1.Width / 2 - 4, j, pictureBox1.Width / 2 + 4, j);
                if (chet % 2 == 0)
                {
                    g1.DrawString(Convert.ToString(j / 40), new Font("Arial", 8), Brushes.Black, pictureBox1.Width / 2 + j, pictureBox1.Height - pictureBox1.Height / 2);
                    g1.DrawString(Convert.ToString(-j / 40), new Font("Arial", 8), Brushes.Black, pictureBox1.Width / 2 - j, pictureBox1.Height - pictureBox1.Height / 2);
                }
                chet++;
            }
            // ось ординат
            g1.DrawLine(p, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            // ось абсцисс
            g1.DrawLine(p, 0, pictureBox1.Height - pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height - pictureBox1.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // рисуем систему координат
            Sis_coor();
            pictureBox1.Image = b2;
        }

        public double F (double x, string equation)
        {
            string NewEquation = "";
            foreach (char c in equation)
            {
                if (c == 'x')
                {
                    NewEquation += x.ToString().Replace(',', '.');
                }
                else
                {
                    NewEquation += c;
                }
            }
            try
            {
                return Convert.ToDouble(new DataTable().Compute(NewEquation, null));
            }
            catch (Exception)
            {
                return -100;    
            }
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            string equation = "";
            equation = EquationTextBox.Text;

            if (F(0, equation) == -100)
            {
                MessageBox.Show("Unknown equation!");
            }
            else
            {
                double x0 = -10;
                double f0 = F(x0, equation);

                double x = -9.98;
                double f = F(x, equation);

                Pen p = new Pen(Color.Blue, 4);
                Bitmap b1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g1 = Graphics.FromImage(b2);

                // проверка режима рисования
                if (OverlayCheckBox.Checked)
                {
                    Sis_coor();
                }
                else
                {
                    g1.Clear(Color.White);
                    Sis_coor();
                }
                while (x <= 10)
                {
                    if (x != 1)
                    {
                        f = F(x, equation);
                        g1.DrawLine(p, Convert.ToInt64(x0 * 40 + pictureBox1.Width / 2), Convert.ToInt64(f0 * 40 + pictureBox1.Height - pictureBox1.Height / 2), Convert.ToInt64(x * 40 + pictureBox1.Width / 2), Convert.ToInt64(f * 40 + pictureBox1.Height - pictureBox1.Height / 2));
                        f0 = f;
                        x0 = x;
                    }
                    x += 0.2;
                }

                // изменяем отображаемую картинку
                pictureBox1.Image = b2;
            }
        }
    }
}