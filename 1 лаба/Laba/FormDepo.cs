using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsTep
{
    public partial class FormDepo : Form
    {
        private readonly DepoCollection depoCollection;

        private readonly Logger logger;

        public FormDepo()
        {
            InitializeComponent();
            depoCollection = new DepoCollection(pictureBoxDepo.Width, pictureBoxDepo.Height);
            logger = LogManager.GetCurrentClassLogger();
        }
        /// Заполнение listBoxLevels
        private void ReloadLevels()
        {
            int index = listBoxLevels.SelectedIndex;
            listBoxLevels.Items.Clear();
            for (int i = 0; i < depoCollection.Keys.Count; i++)
            {
                listBoxLevels.Items.Add(depoCollection.Keys[i]);
            }
            if (listBoxLevels.Items.Count > 0 && (index == -1 || index >=
            listBoxLevels.Items.Count))
            {
                listBoxLevels.SelectedIndex = 0;
            }
            else if (listBoxLevels.Items.Count > 0 && index > -1 && index <
            listBoxLevels.Items.Count)
            {
                listBoxLevels.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depoCollection[listBoxLevels.SelectedItem.ToString()].Draw(gr);
                pictureBoxDepo.Image = bmp;
            }
        }
        private void buttonTakeTep_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                try
                {
                    var teplovoz = depoCollection[listBoxLevels.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (teplovoz != null)
                    {
                        FormTep form = new FormTep();
                        form.SetTrain(teplovoz);
                        form.ShowDialog();
                    }
                    logger.Info($"Забрали поезд {teplovoz} с места {maskedTextBoxPlace.Text}");
                    Draw();
                }
                catch (DepoNotFoundException ex)
                {
                    logger.Warn("Вызвана ошибка DepoNotFoundException");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Вызвана неизвестная ошибка при удалении поезда");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Добавить депо
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDepo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            depoCollection.AddDepo(textBoxNewLevelName.Text);
            logger.Info($"Добавили депо {textBoxNewLevelName.Text}");
            textBoxNewLevelName.Text = "";
            ReloadLevels();
        }
        /// <summary>
        /// Удалить депо
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveDepo_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо { listBoxLevels.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depoCollection.DeleteDepo(listBoxLevels.Text);
                    logger.Info($"Удалили депо {listBoxLevels.SelectedItem.ToString()}");
                    ReloadLevels();
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на депо {listBoxLevels.SelectedItem.ToString()}");
            Draw();
        }
        private void ButtonAddTrain_Click(object sender, EventArgs e)
        {
            var formShipConfig = new FormTepConfig();
            formShipConfig.AddEvent(AddTrain);
            formShipConfig.Show();
        }
        private void AddTrain(Train train)
        {
            if (train != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    if ((depoCollection[listBoxLevels.SelectedItem.ToString()]) + train)
                    {
                        Draw();
                        logger.Info($"Поезд {train} добавлен!");
                    }
                    else
                    {
                        MessageBox.Show("Корабль не удалось поставить");
                    }
                    Draw();
                }
                catch (DepoOverflowException ex)
                {
                    logger.Warn("Вызвано исключение переполнения депо!");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Вызвана неизвестная ошибка!");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depoCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Вызвана неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depoCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (DepoOccupiedPlaceException ex)
                {
                    logger.Warn("Вызвана ошибка DepoOccupiedPlaceException");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Ошибка при загрузке!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Вызвана неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                depoCollection[listBoxLevels.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}