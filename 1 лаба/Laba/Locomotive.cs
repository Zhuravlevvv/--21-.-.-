using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTep
{
    public class Locomotive : Train, IEquatable<Locomotive>
    {
        protected readonly int trainWidth = 120;
        protected readonly int trainHeight = 80;
        protected readonly char separator = ';';
        public Locomotive(int maxSpeed, float weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Locomotive(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction) //передвижение
        {
            float step1 = MaxSpeed * 40 / Weight;
            int step = Convert.ToInt32(step1);
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (Posx + step < pctrWidth - trainWidth)
                    {
                        Posx += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (Posx - step > 0 + 1)

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
                    if (Posy + step < pctrHeight - trainHeight)
                    {
                        Posy += step;
                    }
                    break;
            }
        }
        public override void DrawTep(Graphics g) //отрисовка
        {
            Pen pen = new Pen(Color.Black);
            Brush brBlack = new SolidBrush(Color.Black); //kolesa 1
            g.FillEllipse(brBlack, Posx + 15, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 27, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 39, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 80, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 92, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 104, Posy + 44, 15, 15);
            Brush n = new SolidBrush(MainColor); //kuzov
            List<Point> l = new List<Point>(4);
            l.Add(new Point(Posx + 85, Posy + 35));
            l.Add(new Point(Posx + 85, Posy + 30));
            l.Add(new Point(Posx + 90, Posy + 20));
            l.Add(new Point(Posx + 90, Posy + 35));
            g.FillPolygon(n, l.ToArray<Point>());
            Brush b = new SolidBrush(MainColor);
            List<Point> p = new List<Point>(11);
            p.Add(new Point(Posx + 10, Posy + 19));
            p.Add(new Point(Posx + 10, Posy + 50));
            p.Add(new Point(Posx + 80, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 20));
            p.Add(new Point(Posx + 75, Posy + 15));
            g.FillPolygon(b, p.ToArray<Point>());
            Brush m = new SolidBrush(MainColor); //linered
            List<Point> tp = new List<Point>(4);
            tp.Add(new Point(Posx + 10, Posy + 40));
            tp.Add(new Point(Posx + 10, Posy + 35));
            tp.Add(new Point(Posx + 90, Posy + 35));
            tp.Add(new Point(Posx + 90, Posy + 40));
            g.FillPolygon(m, tp.ToArray<Point>());
            Brush q = new SolidBrush(MainColor); //verx
            List<Point> tq = new List<Point>(4);
            tq.Add(new Point(Posx + 7, Posy + 21));
            tq.Add(new Point(Posx + 121, Posy + 21));
            tq.Add(new Point(Posx + 110, Posy + 14));
            tq.Add(new Point(Posx + 20, Posy + 14));
            g.FillPolygon(q, tq.ToArray<Point>());
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
        public bool Equals(Locomotive other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Locomotive locObj))
            {
                return false;
            }
            else
            {
                return Equals(locObj);
            }
        }
    }
}
