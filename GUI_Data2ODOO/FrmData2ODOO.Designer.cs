namespace GUI_Data2ODOO
{
    partial class FrmData2ODOO
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

       
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
         #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmData2ODOO));
            this.btn_parcourir = new System.Windows.Forms.Button();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.btn_transferer = new System.Windows.Forms.Button();
            this.txt_serveur = new System.Windows.Forms.TextBox();
            this.txt_nomBDD = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.erreur_txt_source = new System.Windows.Forms.TextBox();
            this.btn_min = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_parcourir
            // 
            this.btn_parcourir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_parcourir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_parcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_parcourir.ForeColor = System.Drawing.Color.LightGray;
            this.btn_parcourir.Location = new System.Drawing.Point(294, 282);
            this.btn_parcourir.Name = "btn_parcourir";
            this.btn_parcourir.Size = new System.Drawing.Size(97, 29);
            this.btn_parcourir.TabIndex = 0;
            this.btn_parcourir.Text = "Parcourir";
            this.btn_parcourir.UseVisualStyleBackColor = false;
            this.btn_parcourir.Click += new System.EventHandler(this.btn_parcourir_Click);
            // 
            // txt_source
            // 
            this.txt_source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_source.ForeColor = System.Drawing.Color.DimGray;
            this.txt_source.HideSelection = false;
            this.txt_source.Location = new System.Drawing.Point(46, 239);
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(339, 19);
            this.txt_source.TabIndex = 2;
            this.txt_source.Text = "Source";
            this.txt_source.Enter += new System.EventHandler(this.txt_source_Enter);
            this.txt_source.Leave += new System.EventHandler(this.txt_source_Leave);
            // 
            // btn_transferer
            // 
            this.btn_transferer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transferer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transferer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transferer.ForeColor = System.Drawing.Color.LightGray;
            this.btn_transferer.Location = new System.Drawing.Point(153, 536);
            this.btn_transferer.Name = "btn_transferer";
            this.btn_transferer.Size = new System.Drawing.Size(125, 39);
            this.btn_transferer.TabIndex = 7;
            this.btn_transferer.Text = "Transférer";
            this.btn_transferer.UseVisualStyleBackColor = true;
            this.btn_transferer.Click += new System.EventHandler(this.btn_transferer_Click);
            // 
            // txt_serveur
            // 
            this.txt_serveur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_serveur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_serveur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serveur.ForeColor = System.Drawing.Color.DimGray;
            this.txt_serveur.Location = new System.Drawing.Point(46, 355);
            this.txt_serveur.Name = "txt_serveur";
            this.txt_serveur.Size = new System.Drawing.Size(339, 19);
            this.txt_serveur.TabIndex = 16;
            this.txt_serveur.Text = "Adresse du serveur";
            this.txt_serveur.Enter += new System.EventHandler(this.txt_serveur_Enter);
            this.txt_serveur.Leave += new System.EventHandler(this.txt_serveur_Leave);
            // 
            // txt_nomBDD
            // 
            this.txt_nomBDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_nomBDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomBDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomBDD.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nomBDD.Location = new System.Drawing.Point(46, 458);
            this.txt_nomBDD.Name = "txt_nomBDD";
            this.txt_nomBDD.Size = new System.Drawing.Size(339, 19);
            this.txt_nomBDD.TabIndex = 17;
            this.txt_nomBDD.Text = "Nom de la base";
            this.txt_nomBDD.Enter += new System.EventHandler(this.txt_nomBDD_Enter);
            this.txt_nomBDD.Leave += new System.EventHandler(this.txt_nomBDD_Leave);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.LightGray;
            this.btn_close.Location = new System.Drawing.Point(405, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(19, 18);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "© Gedimat && Interway";
            // 
            // erreur_txt_source
            // 
            this.erreur_txt_source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.erreur_txt_source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.erreur_txt_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.erreur_txt_source.ForeColor = System.Drawing.Color.Red;
            this.erreur_txt_source.Location = new System.Drawing.Point(46, 274);
            this.erreur_txt_source.Name = "erreur_txt_source";
            this.erreur_txt_source.ReadOnly = true;
            this.erreur_txt_source.Size = new System.Drawing.Size(230, 16);
            this.erreur_txt_source.TabIndex = 20;
            this.erreur_txt_source.Text = "Veuillez remplir ce champ";
            this.erreur_txt_source.Visible = false;
            // 
            // btn_min
            // 
            this.btn_min.AutoSize = true;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.btn_min.ForeColor = System.Drawing.Color.LightGray;
            this.btn_min.Location = new System.Drawing.Point(385, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(21, 22);
            this.btn_min.TabIndex = 23;
            this.btn_min.Text = "_";
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // img_logo
            // 
            this.img_logo.Image = global::GUI_Data2ODOO.Properties.Resources.ArrowColor;
            this.img_logo.Location = new System.Drawing.Point(162, 59);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(109, 115);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 15;
            this.img_logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_Data2ODOO.Properties.Resources.navBarC2;
            this.pictureBox2.Location = new System.Drawing.Point(28, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI_Data2ODOO.Properties.Resources.navBarC2;
            this.pictureBox3.Location = new System.Drawing.Point(28, 282);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(373, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI_Data2ODOO.Properties.Resources.navBarC2;
            this.pictureBox4.Location = new System.Drawing.Point(28, 385);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(373, 167);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "DATA2ODOO";
            // 
            // FrmData2ODOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(432, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_transferer);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.erreur_txt_source);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_nomBDD);
            this.Controls.Add(this.txt_serveur);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.btn_parcourir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmData2ODOO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_parcourir;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.Button btn_transferer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.TextBox txt_serveur;
        private System.Windows.Forms.TextBox txt_nomBDD;
        private System.Windows.Forms.Label btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox erreur_txt_source;
        private System.Windows.Forms.Label btn_min;
        private System.Windows.Forms.Label label2;
    }
}

