using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        private readonly char separator = ':';

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
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.Write($"DepoCollection{Environment.NewLine}");
                foreach (var level in depoStages)
                {
                    //начинаем парковку
                    sw.Write($"Depo{separator}{level.Key}{Environment.NewLine}");
                    ITrain train = null;
                    for (int i = 0; (train = level.Value.GetNext(i)) != null; i++)
                    {
                        if (train != null)
                        {
                            //если у нас место не пустое тогда мы записываем тип машины                   
                            if (train.GetType().Name == "Locomotive")
                            {
                                sw.Write($"Locomotive{separator}");
                            }
                            if (train.GetType().Name == "Teplovoz")
                            {
                                sw.Write($"Teplovoz{separator}");
                            }
                            //запись параметровв
                            sw.Write(train + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                Train _train = null;

                string line = sr.ReadLine();
                string key = string.Empty;

                if (line.Contains("DepoCollection"))
                {
                    depoStages.Clear();
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains("Depo"))
                        {
                            key = line.Split(separator)[1];
                            depoStages.Add(key, new Depo<ITrain>(pictureWidth, pictureHeight));
                            line = sr.ReadLine();
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            line = sr.ReadLine();
                            continue;
                        }
                        if (line.Split(separator)[0] == "Locomotive")
                        {
                            _train = new Locomotive(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Teplovoz")
                        {
                            _train = new Teplovoz(line.Split(separator)[1]);
                        }
                        var result = depoStages[key] + _train;
                        if (!result)
                        {
                            return false;
                        }
                        line = sr.ReadLine();
                    }
                    return true;
                }
                return false;
            }
        }
    }
}

 
