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
            this.buttonSetTep = new System.Windows.Forms.Button();
            this.buttonSetLoc = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonTakeTep = new System.Windows.Forms.Button();
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
            // buttonSetTep
            // 
            this.buttonSetTep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetTep.Location = new System.Drawing.Point(760, 0);
            this.buttonSetTep.Name = "buttonSetTep";
            this.buttonSetTep.Size = new System.Drawing.Size(219, 99);
            this.buttonSetTep.TabIndex = 1;
            this.buttonSetTep.Text = "Припарковать тепловоз";
            this.buttonSetTep.UseVisualStyleBackColor = true;
            this.buttonSetTep.Click += new System.EventHandler(this.buttonSetTep_Click);
            // 
            // buttonSetLoc
            // 
            this.buttonSetLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetLoc.Location = new System.Drawing.Point(760, 96);
            this.buttonSetLoc.Name = "buttonSetLoc";
            this.buttonSetLoc.Size = new System.Drawing.Size(219, 99);
            this.buttonSetLoc.TabIndex = 2;
            this.buttonSetLoc.Text = "Припарковать локомотив";
            this.buttonSetLoc.UseVisualStyleBackColor = true;
            this.buttonSetLoc.Click += new System.EventHandler(this.buttonSetLoc_Click);
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
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(66, 35);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(128, 20);
            this.maskedTextBoxPlace.TabIndex = 0;
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
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.buttonSetLoc);
            this.Controls.Add(this.buttonSetTep);
            this.Controls.Add(this.pictureBoxDepo);
            this.Name = "FormDepo";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepo;
        private System.Windows.Forms.Button buttonSetTep;
        private System.Windows.Forms.Button buttonSetLoc;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.Button buttonTakeTep;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
    }
}