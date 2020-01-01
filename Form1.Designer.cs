namespace ControlHorasProyectos
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEmpezar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbUsuario = new System.Windows.Forms.ComboBox();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.ImgRelog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRelog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de horas de proyectos";
            // 
            // BtnEmpezar
            // 
            this.BtnEmpezar.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpezar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEmpezar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpezar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEmpezar.Location = new System.Drawing.Point(70, 209);
            this.BtnEmpezar.Name = "BtnEmpezar";
            this.BtnEmpezar.Size = new System.Drawing.Size(344, 78);
            this.BtnEmpezar.TabIndex = 1;
            this.BtnEmpezar.Text = "Empezar";
            this.BtnEmpezar.UseVisualStyleBackColor = false;
            this.BtnEmpezar.Click += new System.EventHandler(this.BtnEmpezar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Usuario";
            // 
            // CbUsuario
            // 
            this.CbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbUsuario.FormattingEnabled = true;
            this.CbUsuario.ItemHeight = 24;
            this.CbUsuario.Location = new System.Drawing.Point(70, 118);
            this.CbUsuario.Name = "CbUsuario";
            this.CbUsuario.Size = new System.Drawing.Size(344, 32);
            this.CbUsuario.TabIndex = 6;
            this.CbUsuario.SelectedIndexChanged += new System.EventHandler(this.CbUsuario_SelectedIndexChanged);
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.Location = new System.Drawing.Point(67, 365);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(0, 25);
            this.LblRespuesta.TabIndex = 3;
            // 
            // ImgRelog
            // 
            this.ImgRelog.BackColor = System.Drawing.Color.Transparent;
            this.ImgRelog.Image = ((System.Drawing.Image)(resources.GetObject("ImgRelog.Image")));
            this.ImgRelog.Location = new System.Drawing.Point(140, 323);
            this.ImgRelog.Name = "ImgRelog";
            this.ImgRelog.Size = new System.Drawing.Size(193, 93);
            this.ImgRelog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgRelog.TabIndex = 7;
            this.ImgRelog.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.ImgRelog);
            this.Controls.Add(this.CbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.BtnEmpezar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Control de horas de proyectos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgRelog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEmpezar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbUsuario;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.PictureBox ImgRelog;
    }
}

