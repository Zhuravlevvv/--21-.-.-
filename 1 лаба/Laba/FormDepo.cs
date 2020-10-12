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
    public partial class FormDepo : Form
    {
        private readonly Depo<ITrain> depo;
        public FormDepo()
        {
            InitializeComponent();
            depo = new Depo<ITrain>(20, pictureBoxDepo.Width,
            pictureBoxDepo.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depo.Draw(gr);
            pictureBoxDepo.Image = bmp;
        }
        private void buttonSetTep_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var train = new Teplovoz(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = depo + train;
                    Draw();
                }
            }
        }
        private void buttonSetLoc_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var train = new Locomotive(100, 1000, dialog.Color, dopColor: Color.Red);
                int place = depo + train;
                Draw();
            }
        }
        private void buttonTakeTep_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var train = depo - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (train != null)
                {
                    FormTep form = new FormTep();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
