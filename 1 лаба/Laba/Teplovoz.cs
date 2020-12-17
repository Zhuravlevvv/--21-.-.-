using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsTep
{
    public class Teplovoz : Locomotive, IEquatable<Teplovoz>
    {
        public bool Tube { protected set; get; }
        public bool Line { protected set; get; }
        public bool Trumpets { protected set; get; }
        public bool DopOrnament { protected set; get; }

        public Color DopColor { protected set; get; }

        public Teplovoz(int maxSpeed, float weight, Color mainColor,
            Color dopColor, bool tube, bool line, bool trumpets, bool dopOrnament)
            : base(maxSpeed, weight, mainColor, dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Line = line;
            Tube = tube;
            Trumpets = trumpets;
            DopOrnament = dopOrnament;
        }
        public Teplovoz(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Line = Convert.ToBoolean(strs[4]);
                Tube = Convert.ToBoolean(strs[5]);
                Trumpets = Convert.ToBoolean(strs[6]);
                DopOrnament = Convert.ToBoolean(strs[7]);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override void DrawTep(Graphics g)
        {
            base.DrawTep(g);

            if (Tube)
            {
                Brush n = new SolidBrush(MainColor);
                List<Point> l = new List<Point>(4);
                l.Add(new Point(Posx + 85, Posy + 35));
                l.Add(new Point(Posx + 85, Posy + 20));
                l.Add(new Point(Posx + 90, Posy + 20));
                l.Add(new Point(Posx + 90, Posy + 35));

                g.FillPolygon(n, l.ToArray<Point>());
            }

            if (Line)
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 10, Posy + 40));
                tp.Add(new Point(Posx + 10, Posy + 35));
                tp.Add(new Point(Posx + 120, Posy + 35));
                tp.Add(new Point(Posx + 120, Posy + 40));

                g.FillPolygon(m, tp.ToArray<Point>());
            }
            if (Line)
            {

                Brush q = new SolidBrush(DopColor);
                List<Point> tq = new List<Point>(4);
                tq.Add(new Point(Posx + 3, Posy + 23));
                tq.Add(new Point(Posx + 125, Posy + 23));
                tq.Add(new Point(Posx + 110, Posy + 13));
                tq.Add(new Point(Posx + 20, Posy + 13));

                g.FillPolygon(q, tq.ToArray<Point>());
            }

            if (DopOrnament)
            {
                Brush btBlack = new SolidBrush(DopColor); //kolesa 2
                g.FillEllipse(btBlack, Posx + 22, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 34, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 46, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 87, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 98, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 111, Posy + 52, 2, 4);
            }
            if (Trumpets)//1
            {
                Brush w = new SolidBrush(DopColor);
                List<Point> tw = new List<Point>(4);
                tw.Add(new Point(Posx + 90, Posy + 9));
                tw.Add(new Point(Posx + 105, Posy + 9));
                tw.Add(new Point(Posx + 105, Posy + 20));
                tw.Add(new Point(Posx + 90, Posy + 20));

                g.FillPolygon(w, tw.ToArray<Point>());
            }

            if (Trumpets) //trub2
            {
                Brush e = new SolidBrush(DopColor);
                List<Point> te = new List<Point>(4);
                te.Add(new Point(Posx + 65, Posy + 8));
                te.Add(new Point(Posx + 80, Posy + 8));
                te.Add(new Point(Posx + 80, Posy + 20));
                te.Add(new Point(Posx + 65, Posy + 20));
                g.FillPolygon(e, te.ToArray<Point>());
            }

            if (Trumpets)//trub3
            {
                Brush r = new SolidBrush(DopColor);
                List<Point> tr = new List<Point>(4);
                tr.Add(new Point(Posx + 35, Posy + 10));
                tr.Add(new Point(Posx + 50, Posy + 10));
                tr.Add(new Point(Posx + 50, Posy + 20));
                tr.Add(new Point(Posx + 35, Posy + 20));
                g.FillPolygon(r, tr.ToArray<Point>());
            }
            if (Line) //line1
            {
                Brush t = new SolidBrush(DopColor);
                List<Point> tt = new List<Point>(4);
                tt.Add(new Point(Posx + 105, Posy + 22));
                tt.Add(new Point(Posx + 108, Posy + 22));
                tt.Add(new Point(Posx + 108, Posy + 50));
                tt.Add(new Point(Posx + 105, Posy + 50));
                g.FillPolygon(t, tt.ToArray<Point>());
            }
            if (Line) //line2
            {
                Brush y = new SolidBrush(DopColor);
                List<Point> ty = new List<Point>(4);
                ty.Add(new Point(Posx + 90, Posy + 22));
                ty.Add(new Point(Posx + 93, Posy + 22));
                ty.Add(new Point(Posx + 93, Posy + 50));
                ty.Add(new Point(Posx + 90, Posy + 50));

                g.FillPolygon(y, ty.ToArray<Point>());
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}" +
                   $"{separator}{Line}{separator}{Tube}" +
                   $"{separator}{Trumpets}{separator}{DopOrnament}";
        }
        public bool Equals(Teplovoz other)
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
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Line != other.Line)
            {
                return false;
            }
            if (Tube != other.Tube)
            {
                return false;
            }
            if (Trumpets != other.Trumpets)
            {
                return false;
            }
            if (DopOrnament != other.DopOrnament)
            {
                return false;
            }
            return true;
        }
        // перегрузка метода от object
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Teplovoz tepObj))
            {
                return false;
            }
            else
            {
                return Equals(tepObj);
            }
        }
    }
}