using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTep
{
    class DepoCollection
    {
        //Словарь (хранилище) с депо
        readonly Dictionary<string, Depo<ITrain>> depoStages;
        //Возвращение списка названий парковок
        public List<string> Keys => depoStages.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public DepoCollection(int pictureWidth, int pictureHeight)
        {
            depoStages = new Dictionary<string, Depo<ITrain>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        //добавление
        public void AddDepo(string name)
        {
            if (depoStages.ContainsKey(name))
            {
                return;
            }
            depoStages.Add(name, new Depo<ITrain>(pictureWidth, pictureHeight));
        }
        //удаление
        public void DeleteDepo(string name)
        {
            if (depoStages.ContainsKey(name))
            {
                depoStages.Remove(name);
            }
        }
        /// индексатор
        public Depo<ITrain> this[string ind]
        {
            get
            {
                if (depoStages.ContainsKey(ind))
                {
                    return depoStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
