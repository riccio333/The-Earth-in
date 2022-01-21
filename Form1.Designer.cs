namespace The_Earth_in
{
    partial class The_Earth_In
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(The_Earth_In));
            this.cbx_planets = new System.Windows.Forms.ComboBox();
            this.lbl_select = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_EarthIn = new System.Windows.Forms.Label();
            this.lbl_secondary = new System.Windows.Forms.Label();
            this.comparison_image = new System.Windows.Forms.PictureBox();
            this.lab_link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.comparison_image)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_planets
            // 
            this.cbx_planets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_planets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_planets.ForeColor = System.Drawing.Color.Black;
            this.cbx_planets.FormattingEnabled = true;
            this.cbx_planets.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Moon",
            "Mars",
            "Jupiter",
            "Io",
            "Europa",
            "Saturn",
            "Titan",
            "Uranus",
            "Neptune",
            "Triton",
            "Pluto"});
            this.cbx_planets.Location = new System.Drawing.Point(367, 100);
            this.cbx_planets.Name = "cbx_planets";
            this.cbx_planets.Size = new System.Drawing.Size(121, 24);
            this.cbx_planets.TabIndex = 0;
            this.cbx_planets.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.BackColor = System.Drawing.Color.Black;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_select.Location = new System.Drawing.Point(261, 103);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(100, 16);
            this.lbl_select.TabIndex = 1;
            this.lbl_select.Text = "Select a Planet:";
            this.lbl_select.Click += new System.EventHandler(this.lbl_select_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_title.Location = new System.Drawing.Point(165, 36);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(481, 42);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "How many Earth can fit in ...";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_EarthIn
            // 
            this.lbl_EarthIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EarthIn.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_EarthIn.Location = new System.Drawing.Point(12, 140);
            this.lbl_EarthIn.Name = "lbl_EarthIn";
            this.lbl_EarthIn.Size = new System.Drawing.Size(776, 31);
            this.lbl_EarthIn.TabIndex = 3;
            this.lbl_EarthIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_secondary
            // 
            this.lbl_secondary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondary.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_secondary.Location = new System.Drawing.Point(12, 171);
            this.lbl_secondary.Name = "lbl_secondary";
            this.lbl_secondary.Size = new System.Drawing.Size(776, 31);
            this.lbl_secondary.TabIndex = 5;
            this.lbl_secondary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comparison_image
            // 
            this.comparison_image.BackColor = System.Drawing.Color.Black;
            this.comparison_image.Location = new System.Drawing.Point(367, 258);
            this.comparison_image.Name = "comparison_image";
            this.comparison_image.Size = new System.Drawing.Size(70, 51);
            this.comparison_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comparison_image.TabIndex = 4;
            this.comparison_image.TabStop = false;
            // 
            // lab_link
            // 
            this.lab_link.AutoSize = true;
            this.lab_link.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_link.LinkColor = System.Drawing.Color.Cyan;
            this.lab_link.Location = new System.Drawing.Point(0, 161);
            this.lab_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_link.Name = "lab_link";
            this.lab_link.Size = new System.Drawing.Size(165, 16);
            this.lab_link.TabIndex = 19;
            this.lab_link.TabStop = true;
            this.lab_link.Text = "Copyright © 2022, riccio333";
            this.lab_link.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lab_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_link_LinkClicked);
            // 
            // The_Earth_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 177);
            this.Controls.Add(this.lab_link);
            this.Controls.Add(this.lbl_secondary);
            this.Controls.Add(this.comparison_image);
            this.Controls.Add(this.lbl_EarthIn);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.cbx_planets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "The_Earth_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Earth in ...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comparison_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_planets;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_EarthIn;
        private System.Windows.Forms.PictureBox comparison_image;
        private System.Windows.Forms.Label lbl_secondary;
        private System.Windows.Forms.LinkLabel lab_link;
    }
}

