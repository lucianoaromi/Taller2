namespace CapaPresentacion
{
    partial class frmBackup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_backup = new System.Windows.Forms.TextBox();
            this.txt_restore = new System.Windows.Forms.TextBox();
            this.btn_examinar_backup = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_examinar_restore = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.txt_nombre_backup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(288, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "BACKUP / RESTORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Realizar backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ubicación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Restaurar base de datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ubicación:";
            // 
            // txt_backup
            // 
            this.txt_backup.Enabled = false;
            this.txt_backup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_backup.Location = new System.Drawing.Point(167, 119);
            this.txt_backup.Name = "txt_backup";
            this.txt_backup.Size = new System.Drawing.Size(475, 27);
            this.txt_backup.TabIndex = 7;
            this.txt_backup.Text = " Seleccione un destino...";
            // 
            // txt_restore
            // 
            this.txt_restore.Enabled = false;
            this.txt_restore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_restore.Location = new System.Drawing.Point(167, 294);
            this.txt_restore.Name = "txt_restore";
            this.txt_restore.Size = new System.Drawing.Size(475, 27);
            this.txt_restore.TabIndex = 8;
            this.txt_restore.Text = " Seleccione el archivo .bak";
            // 
            // btn_examinar_backup
            // 
            this.btn_examinar_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_examinar_backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_examinar_backup.FlatAppearance.BorderSize = 0;
            this.btn_examinar_backup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_examinar_backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_examinar_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examinar_backup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar_backup.ForeColor = System.Drawing.Color.White;
            this.btn_examinar_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_examinar_backup.Location = new System.Drawing.Point(657, 114);
            this.btn_examinar_backup.Name = "btn_examinar_backup";
            this.btn_examinar_backup.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_examinar_backup.Size = new System.Drawing.Size(150, 34);
            this.btn_examinar_backup.TabIndex = 47;
            this.btn_examinar_backup.Text = "Examinar...";
            this.btn_examinar_backup.UseVisualStyleBackColor = false;
            this.btn_examinar_backup.Click += new System.EventHandler(this.btn_examinar_backup_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backup.Enabled = false;
            this.btn_backup.FlatAppearance.BorderSize = 0;
            this.btn_backup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_backup.Location = new System.Drawing.Point(657, 161);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_backup.Size = new System.Drawing.Size(150, 34);
            this.btn_backup.TabIndex = 48;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_examinar_restore
            // 
            this.btn_examinar_restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_examinar_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_examinar_restore.FlatAppearance.BorderSize = 0;
            this.btn_examinar_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_examinar_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_examinar_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_examinar_restore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_examinar_restore.ForeColor = System.Drawing.Color.White;
            this.btn_examinar_restore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_examinar_restore.Location = new System.Drawing.Point(657, 290);
            this.btn_examinar_restore.Name = "btn_examinar_restore";
            this.btn_examinar_restore.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_examinar_restore.Size = new System.Drawing.Size(150, 34);
            this.btn_examinar_restore.TabIndex = 49;
            this.btn_examinar_restore.Text = "Examinar...";
            this.btn_examinar_restore.UseVisualStyleBackColor = false;
            this.btn_examinar_restore.Click += new System.EventHandler(this.btn_examinar_restore_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restore.Enabled = false;
            this.btn_restore.FlatAppearance.BorderSize = 0;
            this.btn_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.ForeColor = System.Drawing.Color.White;
            this.btn_restore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restore.Location = new System.Drawing.Point(657, 335);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_restore.Size = new System.Drawing.Size(150, 34);
            this.btn_restore.TabIndex = 50;
            this.btn_restore.Text = "Restaurar";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // txt_nombre_backup
            // 
            this.txt_nombre_backup.Enabled = false;
            this.txt_nombre_backup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_backup.Location = new System.Drawing.Point(212, 166);
            this.txt_nombre_backup.Name = "txt_nombre_backup";
            this.txt_nombre_backup.Size = new System.Drawing.Size(430, 29);
            this.txt_nombre_backup.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "Nombre archivo:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(657, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(150, 34);
            this.btnLimpiar.TabIndex = 98;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nombre_backup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_restore);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_examinar_restore);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_backup);
            this.panel1.Controls.Add(this.txt_backup);
            this.panel1.Controls.Add(this.btn_examinar_backup);
            this.panel1.Controls.Add(this.txt_restore);
            this.panel1.Location = new System.Drawing.Point(77, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 471);
            this.panel1.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(25, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 547);
            this.panel2.TabIndex = 100;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1087, 607);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBackup";
            this.Text = "f";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_backup;
        private System.Windows.Forms.TextBox txt_restore;
        private System.Windows.Forms.Button btn_examinar_backup;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_examinar_restore;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.TextBox txt_nombre_backup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}