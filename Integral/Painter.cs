using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Painter
    {
        private object locker = new();
        private Size containerSize;
        private Thread t;
        private Graphics mainGraphics;
        private BufferedGraphics bg;

        Pen pen = new Pen(Color.Black);
        Pen pen_2 = new Pen(Color.Red);

        public double S = 0.0;
        public double result = 0.0;

        public double minOX;
        public double minOY;
        public double maxOX;
        public double maxOY;
        public int accuracy;
        public string functionIntegral;

        public Graphics MainGraphics
        {
            get => mainGraphics;
            set
            {
                lock (locker)
                {
                    mainGraphics = value;
                    ContainerSize = mainGraphics.VisibleClipBounds.Size.ToSize();
                    bg = BufferedGraphicsManager.Current.Allocate(
                        mainGraphics, new Rectangle(new Point(0, 0), ContainerSize)
                    );
                }
            }
        }

        public Size ContainerSize
        {
            get => containerSize;
            set
            {
                containerSize = value;
            }
        }

        public Painter(Graphics mainGraphics)
        {
            this.MainGraphics = mainGraphics;
        }

        public void paint() {

            bg.Graphics.Clear(Color.White);

            Function f = new Function(minOX, maxOX, minOY, maxOY, functionIntegral);
            showAxes(f);

            int step = accuracy;

            for (int i = 0; i <= containerSize.Width - step; i += step)
            {
                bg.Graphics.DrawLine(pen, i, find_y(f,i), i + step, find_y(f,i + step));
            }

            bg.Graphics.DrawLine(pen, containerSize.Width - step, find_y(f, containerSize.Width - step),
                containerSize.Width, find_y(f, containerSize.Width));

            for (int tmp_pix = 0; tmp_pix <= containerSize.Width - step; tmp_pix += step)
            {
                ScreenPoints tmp_point1_screen = new ScreenPoints(tmp_pix, find_y(f, tmp_pix));
                ScreenPoints tmp_point2_screen = new ScreenPoints(tmp_pix + step, find_y(f, tmp_pix + step));

                Decarts tmp_point1_decart = new Decarts(tmp_point1_screen, containerSize, f);
                Decarts tmp_point2_decart = new Decarts(tmp_point2_screen, containerSize, f);

                S += Math.Abs(Math.Abs(tmp_point1_decart.X) - Math.Abs(tmp_point2_decart.X)) * tmp_point1_decart.Y;

                int zero_coordinat_regarding_axis = Convert.ToInt32(containerSize.Height * f.maxY / (f.maxY - f.minY));

                bg.Graphics.DrawLine(pen, tmp_pix, zero_coordinat_regarding_axis, tmp_pix, find_y(f, tmp_pix));
                bg.Graphics.DrawLine(pen, tmp_pix, find_y(f, tmp_pix), tmp_pix + step, find_y(f, tmp_pix));
                bg.Graphics.DrawLine(pen, tmp_pix + step, find_y(f, tmp_pix), tmp_pix + step, zero_coordinat_regarding_axis);

            }

            bg.Render();
        }

        private int find_y(Function f, int i) // pixel
        {
            
            ScreenPoints xS = new ScreenPoints(i);
            Decarts xD = new Decarts(xS, ContainerSize, f);
            double y = f.func(xD.X);
            Decarts yD = new Decarts(0, y);
            ScreenPoints yS = new ScreenPoints(yD, ContainerSize, f);
            return yS.Y;
        }

        private void showAxes(Function f)
        {
            bg.Graphics.DrawLine(pen,  - Convert.ToInt32(containerSize.Width * f.minX / (f.maxX-f.minX)), 0,
                - Convert.ToInt32(containerSize.Width * f.minX / (f.maxX - f.minX)), containerSize.Height);  // OY

            bg.Graphics.DrawLine(pen, 0, Convert.ToInt32(containerSize.Height * f.maxY / (f.maxY - f.minY)), 
                containerSize.Width, Convert.ToInt32(containerSize.Height * f.maxY / (f.maxY - f.minY))); // OX
        }
    }
}
