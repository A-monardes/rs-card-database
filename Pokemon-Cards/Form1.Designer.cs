namespace Pokemon_Cards
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvCartas = new System.Windows.Forms.DataGridView();
            this.picboxCarta = new System.Windows.Forms.PictureBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblPowerText = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblBodyText = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblAtaque1Text = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblAtaque2Text = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblAtaque3Text = new System.Windows.Forms.Label();
            this.lblCosto1 = new System.Windows.Forms.Label();
            this.lblCosto2 = new System.Windows.Forms.Label();
            this.lblCosto3 = new System.Windows.Forms.Label();
            this.lblDano1 = new System.Windows.Forms.Label();
            this.lblDano2 = new System.Windows.Forms.Label();
            this.lblDano3 = new System.Windows.Forms.Label();
            this.lblPowerTitulo = new System.Windows.Forms.Label();
            this.lblBodyTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCartas
            // 
            this.dgvCartas.AllowUserToOrderColumns = true;
            this.dgvCartas.AllowUserToResizeColumns = false;
            this.dgvCartas.AllowUserToResizeRows = false;
            this.dgvCartas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCartas.ColumnHeadersHeight = 29;
            this.dgvCartas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCartas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCartas.Location = new System.Drawing.Point(2, 12);
            this.dgvCartas.MultiSelect = false;
            this.dgvCartas.Name = "dgvCartas";
            this.dgvCartas.RowHeadersWidth = 40;
            this.dgvCartas.RowTemplate.Height = 24;
            this.dgvCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartas.Size = new System.Drawing.Size(836, 426);
            this.dgvCartas.TabIndex = 0;
            this.dgvCartas.SelectionChanged += new System.EventHandler(this.dgvCartas_SelectionChanged);
            // 
            // picboxCarta
            // 
            this.picboxCarta.Location = new System.Drawing.Point(844, 12);
            this.picboxCarta.Name = "picboxCarta";
            this.picboxCarta.Size = new System.Drawing.Size(321, 426);
            this.picboxCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxCarta.TabIndex = 1;
            this.picboxCarta.TabStop = false;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPower.Location = new System.Drawing.Point(1196, 12);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(118, 22);
            this.lblPower.TabIndex = 2;
            this.lblPower.Text = "Poké-Power";
            // 
            // lblPowerText
            // 
            this.lblPowerText.AutoSize = true;
            this.lblPowerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerText.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPowerText.Location = new System.Drawing.Point(1197, 34);
            this.lblPowerText.MaximumSize = new System.Drawing.Size(330, 0);
            this.lblPowerText.Name = "lblPowerText";
            this.lblPowerText.Size = new System.Drawing.Size(35, 16);
            this.lblPowerText.TabIndex = 3;
            this.lblPowerText.Text = "texto";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblBody.Location = new System.Drawing.Point(1196, 89);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(107, 22);
            this.lblBody.TabIndex = 4;
            this.lblBody.Text = "Poké-Body";
            // 
            // lblBodyText
            // 
            this.lblBodyText.AutoSize = true;
            this.lblBodyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyText.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBodyText.Location = new System.Drawing.Point(1197, 111);
            this.lblBodyText.MaximumSize = new System.Drawing.Size(330, 0);
            this.lblBodyText.Name = "lblBodyText";
            this.lblBodyText.Size = new System.Drawing.Size(35, 16);
            this.lblBodyText.TabIndex = 5;
            this.lblBodyText.Text = "texto";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(1266, 189);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(59, 20);
            this.lblTitulo1.TabIndex = 6;
            this.lblTitulo1.Text = "label1";
            // 
            // lblAtaque1Text
            // 
            this.lblAtaque1Text.AutoSize = true;
            this.lblAtaque1Text.Location = new System.Drawing.Point(1197, 218);
            this.lblAtaque1Text.MaximumSize = new System.Drawing.Size(320, 0);
            this.lblAtaque1Text.Name = "lblAtaque1Text";
            this.lblAtaque1Text.Size = new System.Drawing.Size(44, 16);
            this.lblAtaque1Text.TabIndex = 7;
            this.lblAtaque1Text.Text = "label2";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(1266, 297);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo2.TabIndex = 8;
            this.lblTitulo2.Text = "titulo";
            // 
            // lblAtaque2Text
            // 
            this.lblAtaque2Text.AutoSize = true;
            this.lblAtaque2Text.Location = new System.Drawing.Point(1197, 326);
            this.lblAtaque2Text.MaximumSize = new System.Drawing.Size(320, 0);
            this.lblAtaque2Text.Name = "lblAtaque2Text";
            this.lblAtaque2Text.Size = new System.Drawing.Size(35, 16);
            this.lblAtaque2Text.TabIndex = 9;
            this.lblAtaque2Text.Text = "texto";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(1274, 398);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(51, 20);
            this.lblTitulo3.TabIndex = 10;
            this.lblTitulo3.Text = "titulo";
            // 
            // lblAtaque3Text
            // 
            this.lblAtaque3Text.AutoSize = true;
            this.lblAtaque3Text.Location = new System.Drawing.Point(1197, 427);
            this.lblAtaque3Text.MaximumSize = new System.Drawing.Size(320, 0);
            this.lblAtaque3Text.Name = "lblAtaque3Text";
            this.lblAtaque3Text.Size = new System.Drawing.Size(35, 16);
            this.lblAtaque3Text.TabIndex = 11;
            this.lblAtaque3Text.Text = "texto";
            // 
            // lblCosto1
            // 
            this.lblCosto1.AutoSize = true;
            this.lblCosto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto1.Location = new System.Drawing.Point(1176, 189);
            this.lblCosto1.Name = "lblCosto1";
            this.lblCosto1.Size = new System.Drawing.Size(53, 20);
            this.lblCosto1.TabIndex = 12;
            this.lblCosto1.Text = "label1";
            // 
            // lblCosto2
            // 
            this.lblCosto2.AutoSize = true;
            this.lblCosto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto2.Location = new System.Drawing.Point(1176, 297);
            this.lblCosto2.Name = "lblCosto2";
            this.lblCosto2.Size = new System.Drawing.Size(53, 20);
            this.lblCosto2.TabIndex = 13;
            this.lblCosto2.Text = "label2";
            // 
            // lblCosto3
            // 
            this.lblCosto3.AutoSize = true;
            this.lblCosto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto3.Location = new System.Drawing.Point(1176, 398);
            this.lblCosto3.Name = "lblCosto3";
            this.lblCosto3.Size = new System.Drawing.Size(53, 20);
            this.lblCosto3.TabIndex = 14;
            this.lblCosto3.Text = "label3";
            // 
            // lblDano1
            // 
            this.lblDano1.AutoSize = true;
            this.lblDano1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDano1.Location = new System.Drawing.Point(1517, 179);
            this.lblDano1.Name = "lblDano1";
            this.lblDano1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblDano1.Size = new System.Drawing.Size(53, 30);
            this.lblDano1.TabIndex = 15;
            this.lblDano1.Text = "label1";
            // 
            // lblDano2
            // 
            this.lblDano2.AutoSize = true;
            this.lblDano2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDano2.Location = new System.Drawing.Point(1517, 287);
            this.lblDano2.Name = "lblDano2";
            this.lblDano2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblDano2.Size = new System.Drawing.Size(53, 30);
            this.lblDano2.TabIndex = 16;
            this.lblDano2.Text = "label2";
            // 
            // lblDano3
            // 
            this.lblDano3.AutoSize = true;
            this.lblDano3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDano3.Location = new System.Drawing.Point(1517, 388);
            this.lblDano3.Name = "lblDano3";
            this.lblDano3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblDano3.Size = new System.Drawing.Size(53, 30);
            this.lblDano3.TabIndex = 17;
            this.lblDano3.Text = "label3";
            // 
            // lblPowerTitulo
            // 
            this.lblPowerTitulo.AutoSize = true;
            this.lblPowerTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPowerTitulo.Location = new System.Drawing.Point(1334, 14);
            this.lblPowerTitulo.Name = "lblPowerTitulo";
            this.lblPowerTitulo.Size = new System.Drawing.Size(59, 20);
            this.lblPowerTitulo.TabIndex = 18;
            this.lblPowerTitulo.Text = "label1";
            // 
            // lblBodyTitulo
            // 
            this.lblBodyTitulo.AutoSize = true;
            this.lblBodyTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBodyTitulo.Location = new System.Drawing.Point(1325, 91);
            this.lblBodyTitulo.Name = "lblBodyTitulo";
            this.lblBodyTitulo.Size = new System.Drawing.Size(59, 20);
            this.lblBodyTitulo.TabIndex = 19;
            this.lblBodyTitulo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 492);
            this.Controls.Add(this.lblBodyTitulo);
            this.Controls.Add(this.lblPowerTitulo);
            this.Controls.Add(this.lblDano3);
            this.Controls.Add(this.lblDano2);
            this.Controls.Add(this.lblDano1);
            this.Controls.Add(this.lblCosto3);
            this.Controls.Add(this.lblCosto2);
            this.Controls.Add(this.lblCosto1);
            this.Controls.Add(this.lblAtaque3Text);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.lblAtaque2Text);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblAtaque1Text);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.lblBodyText);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblPowerText);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.picboxCarta);
            this.Controls.Add(this.dgvCartas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 539);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX Ruby & Sapphire";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCartas;
        private System.Windows.Forms.PictureBox picboxCarta;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblPowerText;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblBodyText;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblAtaque1Text;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblAtaque2Text;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblAtaque3Text;
        private System.Windows.Forms.Label lblCosto1;
        private System.Windows.Forms.Label lblCosto2;
        private System.Windows.Forms.Label lblCosto3;
        private System.Windows.Forms.Label lblDano1;
        private System.Windows.Forms.Label lblDano2;
        private System.Windows.Forms.Label lblDano3;
        private System.Windows.Forms.Label lblPowerTitulo;
        private System.Windows.Forms.Label lblBodyTitulo;
    }
}

