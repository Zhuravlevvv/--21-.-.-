using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsTep
{
    public class Teplovoz : Locomotive
    {
        public bool Tube { protected set; get; }
        public bool Line { protected set; get; }
        public Color DopColor { protected set; get; }
        public Teplovoz(int maxSpeed, float weight, Color mainColor,
            Color dopColor, bool tube, bool line)
            : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Line = line;
            Tube = tube;
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
            if (Tube)
            {
                Brush w = new SolidBrush(DopColor);
                List<Point> tw = new List<Point>(4);
                tw.Add(new Point(Posx + 90, Posy + 9));
                tw.Add(new Point(Posx + 105, Posy + 9));
                tw.Add(new Point(Posx + 105, Posy + 20));
                tw.Add(new Point(Posx + 90, Posy + 20));

                g.FillPolygon(w, tw.ToArray<Point>());
            }
            if (Tube)
            {
                Brush btBlack = new SolidBrush(DopColor); //kolesa 2
                g.FillEllipse(btBlack, Posx + 22, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 34, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 46, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 87, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 98, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 111, Posy + 52, 2, 4);
            }
            if (Tube) //trub2
            {
                Brush e = new SolidBrush(DopColor);
                List<Point> te = new List<Point>(4);
                te.Add(new Point(Posx + 65, Posy + 8));
                te.Add(new Point(Posx + 80, Posy + 8));
                te.Add(new Point(Posx + 80, Posy + 20));
                te.Add(new Point(Posx + 65, Posy + 20));
                g.FillPolygon(e, te.ToArray<Point>());
            }
            if (Tube)//trub3
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
    }
}
