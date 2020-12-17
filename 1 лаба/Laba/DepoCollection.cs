using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace WindowsFormsTep
{
    class DepoCollection
    {
        //Словарь (хранилище) с депо
        readonly Dictionary<string, Depo<Train>> depoStages;
        //Возвращение списка названий парковок
        public List<string> Keys => depoStages.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ':';

        public DepoCollection(int pictureWidth, int pictureHeight)
        {
            depoStages = new Dictionary<string, Depo<Train>>();
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
            depoStages.Add(name, new Depo<Train>(pictureWidth, pictureHeight));
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
        public Depo<Train> this[string ind]
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
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"DepoCollection");

                    foreach (var level in depoStages)
                    {
                        sw.WriteLine($"Depo{separator}{level.Key}");
                        foreach (ITrain train in level.Value)
                        {
                            if (train.GetType().Name == "Locomotive")
                            {
                                sw.Write($"Locomotive{separator}");
                            }
                            if (train.GetType().Name == "Teplovoz")
                            {
                                sw.Write($"Teplovoz{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(train);
                        }
                    }
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("DepoCollection"))
                {
                    //очищаем записи
                    depoStages.Clear();
                }
                else
                {
                    //если нет записи, то это не те данные
                    throw new FormatException("Неверный формат файла");
                }

                line = sr.ReadLine();
                Train train = null;
                string key = string.Empty;
                while (line != null && line.Contains("Depo"))
                {
                    key = line.Split(separator)[1];
                    depoStages.Add(key, new Depo<Train>(pictureWidth,
                    pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Locomotive") || line.Contains("Teplovoz")))
                    {
                        if (line.Split(separator)[0] == "Locomotive")
                        {
                            train = new Locomotive(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Teplovoz")
                        {
                            train = new Teplovoz(line.Split(separator)[1]);
                        }
                        var result = depoStages[key] + train;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}

 
