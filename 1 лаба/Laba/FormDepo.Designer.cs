namespace WindowsFormsTep
{
    partial class FormDepo
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
            this.pictureBoxDepo = new System.Windows.Forms.PictureBox();
            this.buttonAddTrain = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTakeTep = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.buttonRemoveDepo = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonAddDepo = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.MaskedTextBox();
            this.labelLevels = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).BeginInit();
            this.groupBoxTake.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDepo
            // 
            this.pictureBoxDepo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDepo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDepo.Name = "pictureBoxDepo";
            this.pictureBoxDepo.Size = new System.Drawing.Size(761, 543);
            this.pictureBoxDepo.TabIndex = 0;
            this.pictureBoxDepo.TabStop = false;
            // 
            // buttonAddTrain
            // 
            this.buttonAddTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddTrain.Location = new System.Drawing.Point(768, 142);
            this.buttonAddTrain.Name = "buttonAddTrain";
            this.buttonAddTrain.Size = new System.Drawing.Size(200, 53);
            this.buttonAddTrain.TabIndex = 1;
            this.buttonAddTrain.Text = "Припарковать поезд";
            this.buttonAddTrain.UseVisualStyleBackColor = true;
            this.buttonAddTrain.Click += new System.EventHandler(this.ButtonAddTrain_Click);
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Controls.Add(this.buttonTakeTep);
            this.groupBoxTake.Controls.Add(this.labelPlace);
            this.groupBoxTake.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxTake.Location = new System.Drawing.Point(768, 201);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(200, 173);
            this.groupBoxTake.TabIndex = 3;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Забрать";
            // 
            // buttonTakeTep
            // 
            this.buttonTakeTep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTakeTep.Location = new System.Drawing.Point(40, 81);
            this.buttonTakeTep.Name = "buttonTakeTep";
            this.buttonTakeTep.Size = new System.Drawing.Size(123, 61);
            this.buttonTakeTep.TabIndex = 4;
            this.buttonTakeTep.Text = "Забрать";
            this.buttonTakeTep.UseVisualStyleBackColor = true;
            this.buttonTakeTep.Click += new System.EventHandler(this.buttonTakeTep_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(24, 41);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 1;
            this.labelPlace.Text = "Место";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(66, 35);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(128, 20);
            this.maskedTextBoxPlace.TabIndex = 0;
            // 
            // buttonRemoveDepo
            // 
            this.buttonRemoveDepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveDepo.Location = new System.Drawing.Point(768, 103);
            this.buttonRemoveDepo.Name = "buttonRemoveDepo";
            this.buttonRemoveDepo.Size = new System.Drawing.Size(200, 33);
            this.buttonRemoveDepo.TabIndex = 4;
            this.buttonRemoveDepo.Text = "Удалить депо";
            this.buttonRemoveDepo.UseVisualStyleBackColor = true;
            this.buttonRemoveDepo.Click += new System.EventHandler(this.buttonRemoveDepo_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(848, 41);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 56);
            this.listBoxLevels.TabIndex = 5;
            // 
            // buttonAddDepo
            // 
            this.buttonAddDepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddDepo.Location = new System.Drawing.Point(768, 41);
            this.buttonAddDepo.Name = "buttonAddDepo";
            this.buttonAddDepo.Size = new System.Drawing.Size(74, 56);
            this.buttonAddDepo.TabIndex = 6;
            this.buttonAddDepo.Text = "Добавить депо";
            this.buttonAddDepo.UseVisualStyleBackColor = true;
            this.buttonAddDepo.Click += new System.EventHandler(this.buttonAddDepo_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(848, 12);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(120, 20);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(782, 15);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(60, 13);
            this.labelLevels.TabIndex = 8;
            this.labelLevels.Text = "Название:";
            // 
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.labelLevels);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddDepo);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.buttonRemoveDepo);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.buttonAddTrain);
            this.Controls.Add(this.pictureBoxDepo);
            this.Name = "FormDepo";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepo;
        private System.Windows.Forms.Button buttonAddTrain;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.Button buttonTakeTep;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Button buttonRemoveDepo;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonAddDepo;
        private System.Windows.Forms.MaskedTextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelLevels;
    }
}