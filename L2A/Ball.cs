using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace L2A
{
    public class Ball
    {
        int px = 0;
        int py = 0;
        int size = 0;
        Color color;
        MyForm parent = null;
        Thread bthread = null;

        public Ball(MyForm parent, int px, int py, int size, Color color)
        {
            this.parent = parent;
            this.px = px;
            this.py = py;
            this.size = size;
            this.color = color;
            bthread = new Thread(new ThreadStart(run));
            bthread.Start();
        }
        public int getPX()
        {
            return px;
        }
        public int getPY()
        {
            return py;
        }
        public int getSize()
        {
            return size;
        }
        public Color getColor()
        {
            return color;
        }
        public void terminateBallThread()
        {
            bthread.Abort();
        }
        public void run()
        {
            while (px < parent.Size.Width)
            {
                int gravy = 1;
                int speed = -30;
                int speedy = -30;
                int speedx = 0;
                while (true)
                {
                    speedy += gravy;
                    py += speedy;
                    px += speedx;
                    Thread.Sleep(20);
                    parent.Refresh();
                    if (py > parent.Size.Height)
                    {
                        speedy = speed;
                        speed += 3;
                    }
                    if (speed == 0) break;
                }
            }
        }
    }
}
