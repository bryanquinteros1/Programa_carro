
namespace programacarrr
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
            this.buttoninicio = new System.Windows.Forms.Button();
            this.buttonencender = new System.Windows.Forms.Button();
            this.buttonacelerar = new System.Windows.Forms.Button();
            this.buttonbocina = new System.Windows.Forms.Button();
            this.buttonfrenar = new System.Windows.Forms.Button();
            this.buttonapagar = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.labeldatos = new System.Windows.Forms.Label();
            this.labelvelocidad = new System.Windows.Forms.Label();
            this.buttonsubir = new System.Windows.Forms.Button();
            this.buttonReproducir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoninicio
            // 
            this.buttoninicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttoninicio.BackgroundImage")));
            this.buttoninicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoninicio.Location = new System.Drawing.Point(69, 23);
            this.buttoninicio.Name = "buttoninicio";
            this.buttoninicio.Size = new System.Drawing.Size(146, 37);
            this.buttoninicio.TabIndex = 0;
            this.buttoninicio.Text = "crear carro";
            this.buttoninicio.UseVisualStyleBackColor = true;
            this.buttoninicio.Click += new System.EventHandler(this.buttoninicio_Click);
            // 
            // buttonencender
            // 
            this.buttonencender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonencender.BackgroundImage")));
            this.buttonencender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonencender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonencender.Location = new System.Drawing.Point(69, 78);
            this.buttonencender.Name = "buttonencender";
            this.buttonencender.Size = new System.Drawing.Size(146, 48);
            this.buttonencender.TabIndex = 1;
            this.buttonencender.Text = "encender carro";
            this.buttonencender.UseVisualStyleBackColor = true;
            this.buttonencender.Click += new System.EventHandler(this.buttonencender_Click);
            // 
            // buttonacelerar
            // 
            this.buttonacelerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonacelerar.BackgroundImage")));
            this.buttonacelerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonacelerar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonacelerar.Location = new System.Drawing.Point(69, 145);
            this.buttonacelerar.Name = "buttonacelerar";
            this.buttonacelerar.Size = new System.Drawing.Size(146, 48);
            this.buttonacelerar.TabIndex = 2;
            this.buttonacelerar.Text = "Acelerar carro";
            this.buttonacelerar.UseVisualStyleBackColor = true;
            this.buttonacelerar.Click += new System.EventHandler(this.buttonacelerar_Click);
            // 
            // buttonbocina
            // 
            this.buttonbocina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonbocina.BackgroundImage")));
            this.buttonbocina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonbocina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonbocina.Location = new System.Drawing.Point(101, 212);
            this.buttonbocina.Name = "buttonbocina";
            this.buttonbocina.Size = new System.Drawing.Size(82, 32);
            this.buttonbocina.TabIndex = 3;
            this.buttonbocina.UseVisualStyleBackColor = true;
            this.buttonbocina.Click += new System.EventHandler(this.buttonbocina_Click);
            // 
            // buttonfrenar
            // 
            this.buttonfrenar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonfrenar.BackgroundImage")));
            this.buttonfrenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonfrenar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonfrenar.Location = new System.Drawing.Point(69, 280);
            this.buttonfrenar.Name = "buttonfrenar";
            this.buttonfrenar.Size = new System.Drawing.Size(146, 48);
            this.buttonfrenar.TabIndex = 4;
            this.buttonfrenar.Text = "frenar";
            this.buttonfrenar.UseVisualStyleBackColor = true;
            this.buttonfrenar.Click += new System.EventHandler(this.buttonfrenar_Click);
            // 
            // buttonapagar
            // 
            this.buttonapagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonapagar.BackgroundImage")));
            this.buttonapagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonapagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonapagar.Location = new System.Drawing.Point(69, 351);
            this.buttonapagar.Name = "buttonapagar";
            this.buttonapagar.Size = new System.Drawing.Size(146, 48);
            this.buttonapagar.TabIndex = 5;
            this.buttonapagar.Text = "apagar carro";
            this.buttonapagar.UseVisualStyleBackColor = true;
            this.buttonapagar.Click += new System.EventHandler(this.buttonapagar_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(402, 239);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(361, 215);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // labeldatos
            // 
            this.labeldatos.AutoSize = true;
            this.labeldatos.Location = new System.Drawing.Point(448, 35);
            this.labeldatos.Name = "labeldatos";
            this.labeldatos.Size = new System.Drawing.Size(35, 13);
            this.labeldatos.TabIndex = 7;
            this.labeldatos.Text = "Datos";
            // 
            // labelvelocidad
            // 
            this.labelvelocidad.AutoSize = true;
            this.labelvelocidad.Location = new System.Drawing.Point(448, 113);
            this.labelvelocidad.Name = "labelvelocidad";
            this.labelvelocidad.Size = new System.Drawing.Size(35, 13);
            this.labelvelocidad.TabIndex = 8;
            this.labelvelocidad.Text = "Datos";
            // 
            // buttonsubir
            // 
            this.buttonsubir.Location = new System.Drawing.Point(466, 200);
            this.buttonsubir.Name = "buttonsubir";
            this.buttonsubir.Size = new System.Drawing.Size(77, 26);
            this.buttonsubir.TabIndex = 9;
            this.buttonsubir.Text = "subir";
            this.buttonsubir.UseVisualStyleBackColor = true;
            this.buttonsubir.Click += new System.EventHandler(this.buttonsubir_Click);
            // 
            // buttonReproducir
            // 
            this.buttonReproducir.Location = new System.Drawing.Point(622, 200);
            this.buttonReproducir.Name = "buttonReproducir";
            this.buttonReproducir.Size = new System.Drawing.Size(77, 26);
            this.buttonReproducir.TabIndex = 10;
            this.buttonReproducir.Text = "Reproducir";
            this.buttonReproducir.UseVisualStyleBackColor = true;
            this.buttonReproducir.Click += new System.EventHandler(this.buttonReproducir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 475);
            this.Controls.Add(this.buttonReproducir);
            this.Controls.Add(this.buttonsubir);
            this.Controls.Add(this.labelvelocidad);
            this.Controls.Add(this.labeldatos);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonapagar);
            this.Controls.Add(this.buttonfrenar);
            this.Controls.Add(this.buttonbocina);
            this.Controls.Add(this.buttonacelerar);
            this.Controls.Add(this.buttonencender);
            this.Controls.Add(this.buttoninicio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninicio;
        private System.Windows.Forms.Button buttonencender;
        private System.Windows.Forms.Button buttonacelerar;
        private System.Windows.Forms.Button buttonbocina;
        private System.Windows.Forms.Button buttonfrenar;
        private System.Windows.Forms.Button buttonapagar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label labeldatos;
        private System.Windows.Forms.Label labelvelocidad;
        private System.Windows.Forms.Button buttonsubir;
        private System.Windows.Forms.Button buttonReproducir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

