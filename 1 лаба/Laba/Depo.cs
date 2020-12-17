using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTep
{
    public class Depo<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, ITrain
    {
        private readonly List<T> _places;
       
        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private const int _placeSizeWidth = 210;

        private const int _placeSizeHeight = 80;

        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];
        public Depo(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }
        public static bool operator +(Depo<T> p, T teplovoz)
        {
            if (p._places.Count >= p._maxCount - 3)
            {
                throw new DepoOverflowException();
            }
            if (p._places.Contains(teplovoz))
            {
                throw new DepoAlreadyHaveException();
            }
            p._places.Add(teplovoz);
            return true;
        }
        public static T operator -(Depo<T> p, int index)
        {
            if (index <= -1 || index >= p._places.Count)
            {
                throw new DepoNotFoundException(index);
            }
            T locomotive = p._places[index];
            p._places.RemoveAt(index);
            return locomotive;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(2 + i / 5 * _placeSizeWidth + 5, i % 5 *
                    _placeSizeHeight + 15, pictureWidth, pictureHeight);
                _places[i]?.DrawTep(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        public void Sort() => _places.Sort((IComparer<T>)new TrainComparer());
        public void Dispose() { }     
        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _places.Count;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
