using System;
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
    public partial class FormTepConfig : Form
    {
        Train train = null;

        private event Action<Train> eventAddTrain;

        public FormTepConfig()
        {
            InitializeComponent();
            panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawTep()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTep.Width, pictureBoxTep.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(5, 25, pictureBoxTep.Width, pictureBoxTep.Height);
                train.DrawTep(gr);
                pictureBoxTep.Image = bmp;
            }
        }
        private void LabelLoc_MouseDown(object sender, MouseEventArgs e)
        {
            labelLoc.DoDragDrop(labelLoc.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void LabelTep_MouseDown(object sender, MouseEventArgs e)
        {
            labelTep.DoDragDrop(labelTep.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void PanelTrain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    train = new Locomotive((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Green, Color.Red);
                    break;
                case "Тепловоз":
                    train = new Teplovoz((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value,
                        Color.Green, Color.Gray, checkBoxTrumpets.Checked, checkBoxLines.Checked, checkBoxTrumpets.Checked, checkBoxDopOrnament.Checked);
                    break;
            }
            DrawTep();
        }
        private void PanelTrain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        public void AddEvent(Action<Train> ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = new Action<Train>(ev);
            }
            else
            {
                eventAddTrain += ev;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            train.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawTep();

        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train is Teplovoz)
            {
                (train as Teplovoz).SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                DrawTep();
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }
    }
}
