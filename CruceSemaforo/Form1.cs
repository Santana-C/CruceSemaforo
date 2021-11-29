using System;
using System.Drawing;
using System.Windows.Forms;

namespace CruceSemaforo
{
    public partial class Form1 : Form
    {
        double secs_green = 0;
        double secs_finishing_green = 0.0;
        double secs_yellow = 0;
        double secs_red = 0;
        bool norteSur = true;
        bool stopped = true;
        byte next = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            picSemaforo1.Image = Properties.Resources.apagado;
            picSemaforo1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            picSemaforo3.Image = Properties.Resources.apagado;
            picSemaforo3.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerVerde.Stop();
            timerVerdeParpadenado.Stop();
            timerAmarillo.Stop();
            timerAmarilloParpadeando.Stop();
            timerRojo.Stop();
            timerCambio.Stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Botones
            btnStop.PerformClick();
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;

            //Horientacion
            picSemaforo1.Image = Properties.Resources.rojo;
            picSemaforo1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            picSemaforo3.Image = Properties.Resources.rojo;
            picSemaforo3.Image.RotateFlip(RotateFlipType.Rotate90FlipY);

            //ToGreen
            norteSur = true; 
            secs_green = 0.5;
            lblContador.ForeColor = Color.Chartreuse;
            lblContador.Text = "1";
            next = 1;
            cambiarSemaforos(Properties.Resources.verde);
            timerVerde.Start();
        }

        private void timerCambio_Tick(object sender, EventArgs e)
        {
            timerCambio.Stop();
            Image siguienteColor = Properties.Resources.apagado;
            switch (next)
            {
                case 1:
                    {
                        secs_green = 0.5;
                        timerVerde.Start();
                        siguienteColor = Properties.Resources.verde;
                        lblContador.ForeColor = Color.Chartreuse;
                    }
                    break;

                case 2:
                    {
                        secs_finishing_green = 0.5;
                        timerVerdeParpadenado.Start();
                        siguienteColor = Properties.Resources.verde;
                        lblContador.ForeColor = Color.Chartreuse;
                    }
                    break;

                case 3:
                    {
                        secs_yellow = 0.5;
                        timerAmarillo.Start();
                        siguienteColor = Properties.Resources.amarillo;
                        lblContador.ForeColor = Color.Gold;
                    }
                    break;
                case 4:
                    {
                        secs_red = 0.5;
                        timerRojo.Start();
                        siguienteColor = Properties.Resources.rojo;
                        lblContador.ForeColor = Color.Red;
                    }
                    break;
            }
            lblContador.Text = "1";
            cambiarSemaforos(siguienteColor);
        }

        private void timerVerde_Tick(object sender, EventArgs e)
        {
            if(secs_green == 9.5)
            {
                timerVerde.Stop();
                secs_green = 0;
                lblContador.ForeColor = Color.Black;
                cambiarSemaforos(Properties.Resources.apagado);
                next = 2;
                timerCambio.Start();
            }
            else
            {
                int secs_green_ = ((int)secs_green);
                lblContador.Text = (secs_green_ + 1).ToString();
                secs_green += 0.5;
            }
        }

        private void timerVerdeParpadenado_Tick(object sender, EventArgs e)
        {
            if (secs_finishing_green == 2.5)
            {
                timerVerdeParpadenado.Stop();
                secs_finishing_green = 0;
                lblContador.ForeColor = Color.Black;
                cambiarSemaforos(Properties.Resources.apagado);
                next = 3;
                timerCambio.Start();
            }
            else
            {
                int secs_finishing_green_ = ((int)secs_finishing_green);
                lblContador.Text = (secs_finishing_green_ + 1).ToString();
                if (secs_finishing_green - secs_finishing_green_ > 0)
                {
                    cambiarSemaforos(Properties.Resources.apagado);
                    lblContador.ForeColor = Color.Black;
                }
                else
                {
                    cambiarSemaforos(Properties.Resources.verde);
                    lblContador.ForeColor = Color.Chartreuse;
                }
                secs_finishing_green += 0.5;
            }
        }

        private void timerAmarillo_Tick(object sender, EventArgs e)
        {
            if (secs_yellow == 2.5)
            {
                timerAmarillo.Stop();
                secs_yellow = 0;
                lblContador.ForeColor = Color.Black;
                cambiarSemaforos(Properties.Resources.apagado);
                next = 4;
                timerCambio.Start();
            }
            else
            {
                int secs_yellow_ = ((int)secs_yellow);
                lblContador.Text = (secs_yellow_ + 1).ToString();
                secs_yellow += 0.5;
            }
        }

        private void timerRojo_Tick(object sender, EventArgs e)
        {
            if (secs_red == 1.5)
            {
                timerRojo.Stop();
                secs_red = 0;
                lblContador.ForeColor = Color.Black;
                cambiarSemaforos(Properties.Resources.rojo);
                norteSur = !norteSur;
                next = 1;
                timerCambio.Start();
            }
            else
            {
                int secs_red_ = ((int)secs_red);
                lblContador.Text = (secs_red_ + 1).ToString();
                secs_red += 0.5;
            }
        }

        private void cambiarSemaforos(Image color)
        {
            if (norteSur)
            {
                picSemaforo2.Image = (Image)color.Clone();
                picSemaforo4.Image = (Image)color.Clone();
                picSemaforo4.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            }
            else
            {
                picSemaforo1.Image = (Image)color.Clone();
                picSemaforo1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                picSemaforo3.Image = (Image)color.Clone();
                picSemaforo3.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            }
        }

        private void cambiarTodosLosSemaforos(Image color)
        {
            picSemaforo1.Image = (Image)color.Clone();
            picSemaforo1.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
            picSemaforo2.Image = (Image)color.Clone();
            picSemaforo3.Image = (Image)color.Clone();
            picSemaforo3.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            picSemaforo4.Image = (Image)color.Clone();
            picSemaforo4.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            stopped = !stopped;
            if (secs_green > 0)
                timerVerde.Enabled = stopped;
            else if (secs_finishing_green > 0)
                timerVerdeParpadenado.Enabled = stopped;
            else if (secs_yellow > 0)
                timerAmarillo.Enabled = stopped;
            else if (secs_red > 0)
                timerRojo.Enabled = stopped;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnPlay.Enabled = true;
            btnWarning.Enabled = true;

            secs_green = 0;
            secs_finishing_green = 0;
            secs_yellow = 0;
            secs_red = 0;

            lblContador.Text = "0";
            lblContador.ForeColor = Color.Black;

            timerVerde.Stop();
            timerVerdeParpadenado.Stop();
            timerAmarillo.Stop();
            timerAmarilloParpadeando.Stop();
            timerRojo.Stop();
            timerCambio.Stop();

            cambiarTodosLosSemaforos(Properties.Resources.apagado);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            btnStop.PerformClick();
            btnPlay.Enabled = false;
            btnStop.Enabled = true;
            cambiarTodosLosSemaforos(Properties.Resources.amarillo);
            timerAmarilloParpadeando.Start();
        }

        private void timerAmarilloParpadeando_Tick(object sender, EventArgs e)
        {
            if (lblContador.ForeColor == Color.Black)
            {
                lblContador.ForeColor = Color.Gold;
                cambiarTodosLosSemaforos(Properties.Resources.amarillo);
            }
            else
            {
                lblContador.ForeColor = Color.Black;
                cambiarTodosLosSemaforos(Properties.Resources.apagado);
            }
        }

    }
}
