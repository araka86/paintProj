using System;
using System.Drawing;
using System.Windows.Forms;

namespace paintProj
{
    public class MyGraphics
    {
        public static void myLine(int x0, int y0, int x1, int y1, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int dl;
            int width = bitmap.Width;
            int height = bitmap.Height;

            if (y1 == y0) // Горизонтальная линия
            {
                int xi = x0;
                int dx = x0 < x1 ? 1 : -1;
                dl = Math.Abs(x1 - x0);

                for (int i = 0; i <= dl; i++)
                {
                    if (IsValidCoordinate(xi, y0, width, height))
                        bitmap.SetPixel(xi, y0, color);
                    xi += dx;
                }
            }
            else if (x1 == x0) // Вертикальная линия
            {
                int yi = y0;
                int dy = y0 < y1 ? 1 : -1;
                dl = Math.Abs(y1 - y0);

                for (int i = 0; i <= dl; i++)
                {
                    if (IsValidCoordinate(x0, yi, width, height))
                        bitmap.SetPixel(x0, yi, color);
                    yi += dy;
                }
            }
            else // Диагональная линия
            {
                float m = (float)(y1 - y0) / (x1 - x0);
                float xii = x0, yii = y0;
                float delta_x, delta_y;

                if (Math.Abs(x1 - x0) >= Math.Abs(y1 - y0))
                {
                    dl = Math.Abs(x1 - x0);
                    delta_x = x0 < x1 ? 1 : -1;
                    delta_y = m * delta_x;

                    for (int i = 0; i < dl; i++)
                    {
                        if (IsValidCoordinate((int)xii, (int)yii, width, height))
                            bitmap.SetPixel((int)xii, (int)yii, color);
                        xii += delta_x;
                        yii += delta_y;
                    }
                }
                else
                {
                    dl = Math.Abs(y1 - y0);
                    delta_y = y0 < y1 ? 1 : -1;
                    delta_x = delta_y / m;

                    for (int i = 0; i <= dl; i++)
                    {
                        if (IsValidCoordinate((int)xii, (int)yii, width, height))
                            bitmap.SetPixel((int)xii, (int)yii, color);
                        xii += delta_x;
                        yii += delta_y;
                    }
                }
            }

            pictureBox.Image = bitmap;
        }


        public static void Mycircle(int x0, int y0, float r, Bitmap bitmap, PictureBox pictureBox, Color color)
        {

            int width = bitmap.Width;
            int height = bitmap.Height;
            for (int i = 0; i < 180; i++)
            {
                int xi = (int)(x0 + r * Math.Cos(i * Math.PI / 180));
                int yi = (int)(y0 + r * Math.Sin(i * Math.PI / 180));
                if (IsValidCoordinate(xi, yi, width, height))
                    bitmap.SetPixel(xi, yi, color);
            }
            pictureBox.Image = bitmap;
        }




        public static void MyRadiuscircle(int x0, int y0, float r, int istart, int istop, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            for (int i = istart; i < istop; i++)
            {
                int xi = (int)(x0 + r * Math.Cos(i * Math.PI / 180));
                int yi = (int)(y0 + r * Math.Sin(i * Math.PI / 180));

                if (IsValidCoordinate(xi, yi, width, height))
                    bitmap.SetPixel(xi, yi, color);
            }

            pictureBox.Image = bitmap;
        }




        public static void myElipse(int x0, int y0, int x1, int y1, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;

            // Вычисляем радиусы на основе координат начальной и конечной точки
            int a = Math.Abs(x1 - x0) / 2; // Горизонтальный радиус
            int b = Math.Abs(y1 - y0) / 2; // Вертикальный радиус

            // Вычисляем центр эллипса
            int centerX = x0 + (x1 - x0) / 2;
            int centerY = y0 + (y1 - y0) / 2;

            int iteration = 360;

            for (int i = 0; i < iteration; i++)
            {
                // Вычисляем координаты на границе эллипса
                int xi = (int)(centerX + a * Math.Cos(i * Math.PI / 180)); // Используем 180 для градусов
                int yi = (int)(centerY + b * Math.Sin(i * Math.PI / 180));

                if (IsValidCoordinate(xi, yi, width, height))
                    bitmap.SetPixel(xi, yi, color);
            }

            // Обновляем изображение в PictureBox
            pictureBox.Image = bitmap;
        }




   

        // Метод для проверки, находятся ли координаты в пределах изображения
        private static bool IsValidCoordinate(int x, int y, int width, int height) =>
            x >= 0 && x < width && y >= 0 && y < height;
        


    }
}
