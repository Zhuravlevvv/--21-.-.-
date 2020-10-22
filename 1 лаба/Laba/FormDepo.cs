﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTep
{
    public partial class FormDepo : Form
    {
        private readonly DepoCollection depoCollection;

        public FormDepo()
        {
            InitializeComponent();
            depoCollection = new DepoCollection(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Draw();
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
        /// <summary>
        /// Припарковать тепловоз
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTep_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var teplovoz = new Teplovoz(100, 1000, dialog.Color, dialogDop.Color,
                        true, true);
                        if (depoCollection[listBoxLevels.SelectedItem.ToString()] + teplovoz)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Не припарковано!");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Припарковать локомотив
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetLoc_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var locomotive = new Locomotive(100, 1000, dialog.Color, dopColor: Color.Red);
                    if (depoCollection[listBoxLevels.SelectedItem.ToString()] + locomotive)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Не припарковано!");
                    }
                }
            }
        }
        private void buttonTakeTep_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    var teplovoz = depoCollection[listBoxLevels.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (teplovoz != null)
                    {
                        FormTep form = new FormTep();
                        form.SetTrain(teplovoz);
                        form.ShowDialog();
                    }
                    Draw();
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
                    ReloadLevels();
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }     
    }
}