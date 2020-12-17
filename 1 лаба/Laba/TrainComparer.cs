using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTep
{
    public class TrainComparer : IComparer<Train>
    {
        public int Compare(Train x, Train y)
        {
            if (x is Teplovoz && y is Teplovoz)
            {
                return ComparerTeplovoz((Teplovoz)x, (Teplovoz)y);
            }
            if (x is Teplovoz && y is Locomotive)
            {
                return -1;
            }
            if (x is Locomotive && y is Teplovoz)
            {
                return 1;
            }
            if (x is Locomotive && y is Locomotive)
            {
                return ComparerLocomotive((Locomotive)x, (Locomotive)y);
            }
            return 0;
        }
        public int ComparerLocomotive(Locomotive x, Locomotive y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        public int ComparerTeplovoz(Teplovoz x, Teplovoz y)
        {
            var res = ComparerLocomotive(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Line != y.Line)
            {
                return x.Line.CompareTo(y.Line);
            }
            if (x.Tube != y.Tube)
            {
                return x.Tube.CompareTo(y.Tube);
            }
            if (x.Trumpets != y.Trumpets)
            {
                return x.Trumpets.CompareTo(y.Trumpets);
            }
            if (x.DopOrnament != y.DopOrnament)
            {
                return x.DopOrnament.CompareTo(y.DopOrnament);
            }
            return 0;
        }
    }
}
