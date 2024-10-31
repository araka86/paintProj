using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace paintProj
{
    public partial class Form1 : Form
    {
        Bitmap bitmap, bimapClone;
        enum Tools { none, line, circle, elipse };
        Tools tool = Tools.none;
        int x0, y0;
        float r;
        bool mouseDown = false;
        Color color = Color.Black;


        int istart = 0,
            istop = 360;
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

        }
        private void Form1_Load(object sender, EventArgs e) => SetTextBoxProperties(this);

        
        private void SetTextBoxProperties(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.TabStop = false;
                    textBox.GotFocus += (s, ev) => this.ActiveControl = null;
                    textBox.Click += TextBox_Click;
                }
                else if (control.HasChildren)
                {
                    // Рекурсивно обходим вложенные контейнеры
                    SetTextBoxProperties(control);
                }
            }
        }


        private void TextBox_Click(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                // Отображаем имя TextBox, по которому кликнули
                //   MessageBox.Show($"Клик по111 {textBox.Name}!");

                tbColor1.BackColor = textBox.BackColor;
                color = textBox.BackColor;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
 
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            tool = Tools.line;
        }


        //момент нажатия
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tool != Tools.none)
            {
                x0 = e.X;
                y0 = e.Y;
                mouseDown = true;
            }
        }


        //момент движения мишки
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((tool != Tools.none) && (mouseDown))
            {

                bimapClone = (Bitmap)bitmap.Clone();
                switch (tool)
                {
                    case Tools.line:
                        MyGraphics.myLine(x0, y0, e.X, e.Y, bitmap, pictureBox1, color);
                        break;
                    case Tools.circle:
                        r = (float)Math.Sqrt((e.X - x0) * (e.X - x0) + (e.Y - y0) + (e.Y - y0));
                        MyGraphics.MyRadiuscircle(x0, y0, r, istart, istop, bitmap, pictureBox1, color);
                        break;
               
                    case Tools.elipse:
                        MyGraphics.myElipse(x0, y0, e.X, e.Y, bitmap, pictureBox1, color);
                        break;
                }
                bitmap = bimapClone;


            }

        }



        //момент отпускания
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((tool != Tools.none) && (mouseDown))
            {

                switch (tool)
                {
                    case Tools.line:
                        MyGraphics.myLine(x0, y0, e.X, e.Y, bitmap, pictureBox1, color);
                        break;
                    case Tools.circle:
                        r = (float)Math.Sqrt((e.X - x0) * (e.X - x0) + (e.Y - y0) + (e.Y - y0));
                        MyGraphics.MyRadiuscircle(x0, y0, r, istart, istop, bitmap, pictureBox1, color);
                        break;
                    case Tools.elipse:
                        MyGraphics.myElipse(x0, y0, e.X, e.Y, bitmap, pictureBox1, color);
                        break;
                }
                mouseDown = false;

            }
        }

        private void btnCircle_Click(object sender, EventArgs e) => tool = Tools.circle;
         

        private void btnElipse_Click(object sender, EventArgs e) => tool = Tools.elipse;
        

        private void btnColorDiag_Click(object sender, EventArgs e)
        {

            // Создаём объект ColorDialog
            using (ColorDialog MyDialog = new ColorDialog())
            {
                // Разрешаем пользователю выбирать дополнительные цвета
                MyDialog.AllowFullOpen = true;
                // Показываем справку (опционально)
                MyDialog.ShowHelp = true;
                // Устанавливаем начальный цвет на текущий цвет pictureBox1
                MyDialog.Color = pictureBox1.BackColor;

                // Открываем диалог выбора цвета
                if (MyDialog.ShowDialog() == DialogResult.OK)
                {
                    // Применяем выбранный цвет в качестве фона pictureBox1
                    //   pictureBox1.BackColor = MyDialog.Color;
                    tbColor1.BackColor = MyDialog.Color;
                    color = MyDialog.Color;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bitmap = null;
            pictureBox1.Image = null;
            tool = Tools.none;
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
    }
}


