namespace Auto_Shutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NSeconde = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NMinute = new System.Windows.Forms.NumericUpDown();
            this.NHeur = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.THeur = new System.Windows.Forms.Timer(this.components);
            this.TMinute = new System.Windows.Forms.Timer(this.components);
            this.TSecond = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSeconde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHeur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NSeconde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NMinute);
            this.panel1.Controls.Add(this.NHeur);
            this.panel1.Location = new System.Drawing.Point(40, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 37);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minute";
            // 
            // NSeconde
            // 
            this.NSeconde.Location = new System.Drawing.Point(254, 3);
            this.NSeconde.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NSeconde.Name = "NSeconde";
            this.NSeconde.Size = new System.Drawing.Size(63, 25);
            this.NSeconde.TabIndex = 2;
            this.NSeconde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hour";
            // 
            // NMinute
            // 
            this.NMinute.Location = new System.Drawing.Point(122, 3);
            this.NMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NMinute.Name = "NMinute";
            this.NMinute.Size = new System.Drawing.Size(63, 25);
            this.NMinute.TabIndex = 1;
            this.NMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NHeur
            // 
            this.NHeur.Location = new System.Drawing.Point(3, 3);
            this.NHeur.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NHeur.Name = "NHeur";
            this.NHeur.Size = new System.Drawing.Size(63, 25);
            this.NHeur.TabIndex = 0;
            this.NHeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(314, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Off";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(166, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Shutdown";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(18, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reboot";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // THeur
            // 
            this.THeur.Interval = 1000;
            this.THeur.Tick += new System.EventHandler(this.THeur_Tick);
            // 
            // TMinute
            // 
            this.TMinute.Interval = 1000;
            this.TMinute.Tick += new System.EventHandler(this.TMinute_Tick);
            // 
            // TSecond
            // 
            this.TSecond.Interval = 1000;
            this.TSecond.Tick += new System.EventHandler(this.TSecond_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(314, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(166, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 146);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Shutdown";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSeconde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHeur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NSeconde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NMinute;
        private System.Windows.Forms.NumericUpDown NHeur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer THeur;
        private System.Windows.Forms.Timer TMinute;
        private System.Windows.Forms.Timer TSecond;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

