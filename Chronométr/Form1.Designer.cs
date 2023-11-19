namespace Chronométr
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LB = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.T = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB.Location = new System.Drawing.Point(35, 35);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(391, 66);
            this.LB.TabIndex = 0;
            this.LB.Text = "00:00:00:000";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Chartreuse;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Location = new System.Drawing.Point(59, 173);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(131, 46);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start   ";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Stop.Location = new System.Drawing.Point(210, 173);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(131, 46);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop   ";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(522, 173);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(153, 46);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear    ";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Gold;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(365, 173);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 46);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save  ";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.list.ForeColor = System.Drawing.SystemColors.Info;
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(588, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(168, 148);
            this.list.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Image = global::Chronométr.Properties.Resources.clear;
            this.pictureBox4.Location = new System.Drawing.Point(632, 183);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gold;
            this.pictureBox3.Image = global::Chronométr.Properties.Resources.save;
            this.pictureBox3.Location = new System.Drawing.Point(459, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Image = global::Chronométr.Properties.Resources.stop;
            this.pictureBox2.Location = new System.Drawing.Point(302, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox1.Image = global::Chronométr.Properties.Resources.start1;
            this.pictureBox1.Location = new System.Drawing.Point(154, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // T
            // 
            this.T.Interval = 10;
            this.T.Tick += new System.EventHandler(this.T_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.LB);
            this.Name = "Form1";
            this.Text = "Chrono";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer T;
    }
}

