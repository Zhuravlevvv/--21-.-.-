using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTep
{
    class Teplovoz
    {
        private int Posx;
        private int Posy;

        private int pctrWidth;
        private int pctrHeight;

        private const int tepWidth = 190;
        private const int tepHeight = 80;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }

        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
       

        public bool Tube { private set; get; }
        public bool Line { private set; get; }

        public Teplovoz(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool tube, bool line)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Line = line;
            Tube = tube;
           
        }

        public void SetPosition(int x, int y, int width, int height) //начальная поз.
        {
            Posx = x;
            Posy = y;
            pctrWidth = width;
            pctrHeight = height;
        }

        public void MoveTransport(Direction direction) //передвижениt 
        {
            float step1 = MaxSpeed * 30 / Weight;
            int step = Convert.ToInt32(step1);
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (Posx + step < pctrWidth - tepWidth)
                    {
                        Posx += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (Posx - step > 0)

                    {
                        Posx -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (Posy - step > 0)
                    {
                        Posy -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (Posy + step < pctrHeight - tepHeight)
                    {
                        Posy += step;
                    }
                    break;
            }
        }

        public void DrawTep(Graphics g) //отрисовка
        {
            Pen pen = new Pen(Color.Black);

            if (Tube)
            {
                Brush n = new SolidBrush(MainColor);
                List<Point> l = new List<Point>(4);
                l.Add(new Point(Posx + 85, Posy + 35));
                l.Add(new Point(Posx + 85, Posy + 30));
                l.Add(new Point(Posx + 90, Posy + 20));
                l.Add(new Point(Posx + 90, Posy + 35));

                g.FillPolygon(n, l.ToArray<Point>());
            }

            Brush b = new SolidBrush(MainColor);
            List<Point> p = new List<Point>(11);
            p.Add(new Point(Posx + 10, Posy + 19));
            p.Add(new Point(Posx + 10, Posy + 50));
            p.Add(new Point(Posx + 80, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 20));
            p.Add(new Point(Posx + 75, Posy + 15));

            g.FillPolygon(b, p.ToArray<Point>());

            if (Line)//1
            {
                Brush m = new SolidBrush(Color.Yellow);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 10, Posy + 40));
                tp.Add(new Point(Posx + 10, Posy + 35));
                tp.Add(new Point(Posx + 120, Posy + 35));
                tp.Add(new Point(Posx + 120, Posy + 40));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            if (Line)//verx
            {
                Brush m = new SolidBrush(Color.Gray);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 3, Posy + 23));
                tp.Add(new Point(Posx + 125, Posy + 23));
                tp.Add(new Point(Posx + 110, Posy + 13));
                tp.Add(new Point(Posx + 20, Posy + 13));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            if (Line)//trub1
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 90, Posy + 9));
                tp.Add(new Point(Posx + 105, Posy + 9));
                tp.Add(new Point(Posx + 105, Posy + 20));
                tp.Add(new Point(Posx + 90, Posy + 20));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            if(Line)//trub2
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 65, Posy + 8));
                tp.Add(new Point(Posx + 80, Posy + 8));
                tp.Add(new Point(Posx + 80, Posy + 20));
                tp.Add(new Point(Posx + 65, Posy + 20));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            if (Line)//trub3
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 35, Posy + 10));
                tp.Add(new Point(Posx + 50, Posy + 10));
                tp.Add(new Point(Posx + 50, Posy + 20));
                tp.Add(new Point(Posx + 35, Posy + 20));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            if (Line)//2
            {
                Brush m = new SolidBrush(Color.Yellow);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 105, Posy + 22));
                tp.Add(new Point(Posx + 108, Posy + 22));
                tp.Add(new Point(Posx + 108, Posy + 48));
                tp.Add(new Point(Posx + 105, Posy + 48));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            if (Line)//3
            {
                Brush m = new SolidBrush(Color.Yellow);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 90, Posy + 22));
                tp.Add(new Point(Posx + 93, Posy + 22));
                tp.Add(new Point(Posx + 93, Posy + 48));
                tp.Add(new Point(Posx + 90, Posy + 48));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            Brush brBlack = new SolidBrush(Color.Black); //kolesa 1
            g.FillEllipse(brBlack, Posx + 15, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 27, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 39, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 80, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 92, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 104, Posy + 45, 15, 15);

            Brush btBlack = new SolidBrush(Color.Gray); //kolesa 2
            g.FillEllipse(btBlack, Posx + 22, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 34, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 46, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 87, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 98, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 111, Posy + 52, 2, 4);


          

        }
    }
}
