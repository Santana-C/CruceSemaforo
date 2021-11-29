
namespace CruceSemaforo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picSemaforo1 = new System.Windows.Forms.PictureBox();
            this.picSemaforo2 = new System.Windows.Forms.PictureBox();
            this.picSemaforo3 = new System.Windows.Forms.PictureBox();
            this.picSemaforo4 = new System.Windows.Forms.PictureBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.timerVerde = new System.Windows.Forms.Timer(this.components);
            this.timerAmarillo = new System.Windows.Forms.Timer(this.components);
            this.timerRojo = new System.Windows.Forms.Timer(this.components);
            this.timerVerdeParpadenado = new System.Windows.Forms.Timer(this.components);
            this.timerAmarilloParpadeando = new System.Windows.Forms.Timer(this.components);
            this.timerCambio = new System.Windows.Forms.Timer(this.components);
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.Transparent;
            this.pnlControles.Controls.Add(this.btnWarning);
            this.pnlControles.Controls.Add(this.btnStop);
            this.pnlControles.Controls.Add(this.btnPause);
            this.pnlControles.Controls.Add(this.btnPlay);
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(183, 52);
            this.pnlControles.TabIndex = 0;
            // 
            // btnWarning
            // 
            this.btnWarning.BackColor = System.Drawing.Color.Gray;
            this.btnWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWarning.FlatAppearance.BorderSize = 0;
            this.btnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarning.Image = global::CruceSemaforo.Properties.Resources.warning;
            this.btnWarning.Location = new System.Drawing.Point(132, 3);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(40, 40);
            this.btnWarning.TabIndex = 4;
            this.btnWarning.UseVisualStyleBackColor = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Gray;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::CruceSemaforo.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(89, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Gray;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::CruceSemaforo.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(46, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gray;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::CruceSemaforo.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picSemaforo1
            // 
            this.picSemaforo1.BackColor = System.Drawing.Color.Transparent;
            this.picSemaforo1.Image = global::CruceSemaforo.Properties.Resources.apagado;
            this.picSemaforo1.Location = new System.Drawing.Point(65, 195);
            this.picSemaforo1.Name = "picSemaforo1";
            this.picSemaforo1.Size = new System.Drawing.Size(75, 72);
            this.picSemaforo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSemaforo1.TabIndex = 1;
            this.picSemaforo1.TabStop = false;
            // 
            // picSemaforo2
            // 
            this.picSemaforo2.BackColor = System.Drawing.Color.Transparent;
            this.picSemaforo2.Image = global::CruceSemaforo.Properties.Resources.apagado;
            this.picSemaforo2.Location = new System.Drawing.Point(272, 63);
            this.picSemaforo2.Name = "picSemaforo2";
            this.picSemaforo2.Size = new System.Drawing.Size(75, 72);
            this.picSemaforo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSemaforo2.TabIndex = 2;
            this.picSemaforo2.TabStop = false;
            // 
            // picSemaforo3
            // 
            this.picSemaforo3.BackColor = System.Drawing.Color.Transparent;
            this.picSemaforo3.Image = global::CruceSemaforo.Properties.Resources.apagado;
            this.picSemaforo3.Location = new System.Drawing.Point(401, 275);
            this.picSemaforo3.Name = "picSemaforo3";
            this.picSemaforo3.Size = new System.Drawing.Size(75, 72);
            this.picSemaforo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSemaforo3.TabIndex = 3;
            this.picSemaforo3.TabStop = false;
            // 
            // picSemaforo4
            // 
            this.picSemaforo4.BackColor = System.Drawing.Color.Transparent;
            this.picSemaforo4.Image = global::CruceSemaforo.Properties.Resources.apagado;
            this.picSemaforo4.Location = new System.Drawing.Point(195, 397);
            this.picSemaforo4.Name = "picSemaforo4";
            this.picSemaforo4.Size = new System.Drawing.Size(75, 72);
            this.picSemaforo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSemaforo4.TabIndex = 4;
            this.picSemaforo4.TabStop = false;
            // 
            // lblContador
            // 
            this.lblContador.BackColor = System.Drawing.Color.Black;
            this.lblContador.Font = new System.Drawing.Font("DS-Digital", 95F);
            this.lblContador.ForeColor = System.Drawing.Color.White;
            this.lblContador.Location = new System.Drawing.Point(195, 195);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(152, 152);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "0";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerVerde
            // 
            this.timerVerde.Interval = 500;
            this.timerVerde.Tick += new System.EventHandler(this.timerVerde_Tick);
            // 
            // timerAmarillo
            // 
            this.timerAmarillo.Interval = 500;
            this.timerAmarillo.Tick += new System.EventHandler(this.timerAmarillo_Tick);
            // 
            // timerRojo
            // 
            this.timerRojo.Interval = 500;
            this.timerRojo.Tick += new System.EventHandler(this.timerRojo_Tick);
            // 
            // timerVerdeParpadenado
            // 
            this.timerVerdeParpadenado.Interval = 500;
            this.timerVerdeParpadenado.Tick += new System.EventHandler(this.timerVerdeParpadenado_Tick);
            // 
            // timerAmarilloParpadeando
            // 
            this.timerAmarilloParpadeando.Interval = 500;
            this.timerAmarilloParpadeando.Tick += new System.EventHandler(this.timerAmarilloParpadeando_Tick);
            // 
            // timerCambio
            // 
            this.timerCambio.Interval = 500;
            this.timerCambio.Tick += new System.EventHandler(this.timerCambio_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CruceSemaforo.Properties.Resources.SemaforoCruce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(542, 542);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.picSemaforo4);
            this.Controls.Add(this.picSemaforo3);
            this.Controls.Add(this.picSemaforo2);
            this.Controls.Add(this.picSemaforo1);
            this.Controls.Add(this.pnlControles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(558, 581);
            this.MinimumSize = new System.Drawing.Size(558, 581);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semáforo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforo4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.PictureBox picSemaforo1;
        private System.Windows.Forms.PictureBox picSemaforo2;
        private System.Windows.Forms.PictureBox picSemaforo3;
        private System.Windows.Forms.PictureBox picSemaforo4;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Timer timerVerde;
        private System.Windows.Forms.Timer timerAmarillo;
        private System.Windows.Forms.Timer timerRojo;
        private System.Windows.Forms.Timer timerVerdeParpadenado;
        private System.Windows.Forms.Timer timerAmarilloParpadeando;
        private System.Windows.Forms.Timer timerCambio;
    }
}

