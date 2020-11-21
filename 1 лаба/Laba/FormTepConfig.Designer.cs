namespace WindowsFormsTep
{
    partial class FormTepConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTep = new System.Windows.Forms.Panel();
            this.pictureBoxTep = new System.Windows.Forms.PictureBox();
            this.groupBoxTrainType = new System.Windows.Forms.GroupBox();
            this.labelTep = new System.Windows.Forms.Label();
            this.labelLoc = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxDopOrnament = new System.Windows.Forms.CheckBox();
            this.checkBoxTrumpets = new System.Windows.Forms.CheckBox();
            this.checkBoxLines = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.panelTep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTep)).BeginInit();
            this.groupBoxTrainType.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.panelBlack.SuspendLayout();
            this.panelWhite.SuspendLayout();
            this.panelGreen.SuspendLayout();
            this.panelBlue.SuspendLayout();
            this.panelRed.SuspendLayout();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTep
            // 
            this.panelTep.AllowDrop = true;
            this.panelTep.Controls.Add(this.pictureBoxTep);
            this.panelTep.Location = new System.Drawing.Point(275, 43);
            this.panelTep.Name = "panelTep";
            this.panelTep.Size = new System.Drawing.Size(282, 146);
            this.panelTep.TabIndex = 0;
            this.panelTep.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragDrop);
            this.panelTep.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragEnter);
            this.panelTep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pictureBoxTep
            // 
            this.pictureBoxTep.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxTep.Name = "pictureBoxTep";
            this.pictureBoxTep.Size = new System.Drawing.Size(252, 116);
            this.pictureBoxTep.TabIndex = 0;
            this.pictureBoxTep.TabStop = false;
            this.pictureBoxTep.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragDrop);
            this.pictureBoxTep.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragEnter);
            // 
            // groupBoxTrainType
            // 
            this.groupBoxTrainType.Controls.Add(this.labelTep);
            this.groupBoxTrainType.Controls.Add(this.labelLoc);
            this.groupBoxTrainType.Location = new System.Drawing.Point(44, 58);
            this.groupBoxTrainType.Name = "groupBoxTrainType";
            this.groupBoxTrainType.Size = new System.Drawing.Size(148, 116);
            this.groupBoxTrainType.TabIndex = 1;
            this.groupBoxTrainType.TabStop = false;
            this.groupBoxTrainType.Text = "Тип поезда";
            // 
            // labelTep
            // 
            this.labelTep.AllowDrop = true;
            this.labelTep.BackColor = System.Drawing.SystemColors.Control;
            this.labelTep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTep.Location = new System.Drawing.Point(18, 68);
            this.labelTep.Name = "labelTep";
            this.labelTep.Size = new System.Drawing.Size(100, 28);
            this.labelTep.TabIndex = 1;
            this.labelTep.Text = "Тепловоз";
            this.labelTep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTep_MouseDown);
            // 
            // labelLoc
            // 
            this.labelLoc.AllowDrop = true;
            this.labelLoc.BackColor = System.Drawing.SystemColors.Control;
            this.labelLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoc.Location = new System.Drawing.Point(18, 27);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(100, 28);
            this.labelLoc.TabIndex = 0;
            this.labelLoc.Text = "Локомотив";
            this.labelLoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelLoc_MouseDown);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BackColor = System.Drawing.SystemColors.Control;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 16);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(87, 28);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BackColor = System.Drawing.SystemColors.Control;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(112, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(87, 28);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelFuchsia);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Location = new System.Drawing.Point(589, 43);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(206, 131);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Controls.Add(this.panel12);
            this.panelBlack.Location = new System.Drawing.Point(156, 42);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(43, 42);
            this.panelBlack.TabIndex = 10;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(43, -1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(43, 42);
            this.panel12.TabIndex = 9;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Controls.Add(this.panel10);
            this.panelWhite.Location = new System.Drawing.Point(156, 83);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(43, 42);
            this.panelWhite.TabIndex = 10;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(43, -1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(43, 42);
            this.panel10.TabIndex = 9;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Controls.Add(this.panel8);
            this.panelGreen.Location = new System.Drawing.Point(112, 83);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(43, 42);
            this.panelGreen.TabIndex = 10;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(43, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(43, 42);
            this.panel8.TabIndex = 9;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Controls.Add(this.panel6);
            this.panelBlue.Location = new System.Drawing.Point(112, 42);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(43, 42);
            this.panelBlue.TabIndex = 8;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(43, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(43, 42);
            this.panel6.TabIndex = 9;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(50, 83);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(43, 42);
            this.panelYellow.TabIndex = 8;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(50, 42);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(43, 42);
            this.panelOrange.TabIndex = 7;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Controls.Add(this.panel3);
            this.panelRed.Location = new System.Drawing.Point(6, 42);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(43, 42);
            this.panelRed.TabIndex = 5;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(47, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 42);
            this.panel3.TabIndex = 6;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuchsia.Location = new System.Drawing.Point(6, 83);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(43, 42);
            this.panelFuchsia.TabIndex = 4;
            this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(686, 243);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 27);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(686, 276);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 27);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxDopOrnament);
            this.groupBoxParams.Controls.Add(this.checkBoxTrumpets);
            this.groupBoxParams.Controls.Add(this.checkBoxLines);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(44, 234);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(278, 128);
            this.groupBoxParams.TabIndex = 7;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxDopOrnament
            // 
            this.checkBoxDopOrnament.AutoSize = true;
            this.checkBoxDopOrnament.Location = new System.Drawing.Point(165, 79);
            this.checkBoxDopOrnament.Name = "checkBoxDopOrnament";
            this.checkBoxDopOrnament.Size = new System.Drawing.Size(59, 17);
            this.checkBoxDopOrnament.TabIndex = 6;
            this.checkBoxDopOrnament.Text = "Диски";
            this.checkBoxDopOrnament.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrumpets
            // 
            this.checkBoxTrumpets.AutoSize = true;
            this.checkBoxTrumpets.Location = new System.Drawing.Point(165, 56);
            this.checkBoxTrumpets.Name = "checkBoxTrumpets";
            this.checkBoxTrumpets.Size = new System.Drawing.Size(58, 17);
            this.checkBoxTrumpets.TabIndex = 5;
            this.checkBoxTrumpets.Text = "Трубы";
            this.checkBoxTrumpets.UseVisualStyleBackColor = true;
            // 
            // checkBoxLines
            // 
            this.checkBoxLines.AutoSize = true;
            this.checkBoxLines.Location = new System.Drawing.Point(165, 33);
            this.checkBoxLines.Name = "checkBoxLines";
            this.checkBoxLines.Size = new System.Drawing.Size(103, 17);
            this.checkBoxLines.TabIndex = 4;
            this.checkBoxLines.Text = "Крыша + линии";
            this.checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(18, 84);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(18, 42);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(15, 68);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(29, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(15, 23);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // FormTepConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxTrainType);
            this.Controls.Add(this.panelTep);
            this.Name = "FormTepConfig";
            this.Text = "Конфигурация";
            this.panelTep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTep)).EndInit();
            this.groupBoxTrainType.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.panelBlack.ResumeLayout(false);
            this.panelWhite.ResumeLayout(false);
            this.panelGreen.ResumeLayout(false);
            this.panelBlue.ResumeLayout(false);
            this.panelRed.ResumeLayout(false);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTep;
        private System.Windows.Forms.PictureBox pictureBoxTep;
        private System.Windows.Forms.GroupBox groupBoxTrainType;
        private System.Windows.Forms.Label labelTep;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxDopOrnament;
        private System.Windows.Forms.CheckBox checkBoxTrumpets;
        private System.Windows.Forms.CheckBox checkBoxLines;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
    }
}