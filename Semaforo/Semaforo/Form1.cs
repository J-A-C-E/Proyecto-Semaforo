using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Reiniciar()
        {
            //TIMMERS ALTO
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

            //VARIABLES
            intermitente = true;
            contadorMiliSegundo = 1;
            btnBlanco.Text = contadorMiliSegundo.ToString();

            //Semaforo 1
            pbVerde1.Visible = true;
            pbAmarillo1.Visible = false;
            pbRojo1.Visible = false;

            //Semaforo 2
            pbVerde2.Visible = true;
            pbAmarillo2.Visible = false;
            pbRojo2.Visible = false;

            //Semaforo 3
            pbVerde3.Visible = true;
            pbAmarillo3.Visible = false;
            pbRojo3.Visible = false;

            //Semaforo 4
            pbVerde4.Visible = true;
            pbAmarillo4.Visible = false;
            pbRojo4.Visible = false;

            //DISPLAY COLORES VARIABLES
            contador = 1;
            contadorParpadeo = 1;
            contadorAmarillo = 1;
            contadorRojo = 1;

            //DIPLAY COLORES PANTALLA REINICIO
            btnVerde.Text = 1.ToString();
            btnAmarillo.Text = "";
            btnRojo.Text = "";

            //TIMMER START
            timer1.Start();
            timer2.Start();


           
        }

        bool intermitente = true;
        double contadorMiliSegundo = 1;        
 

        //TIMMER 1 PRENDE Y APAGA LOS SEMAFOROS
        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorMiliSegundo = contadorMiliSegundo + 0.5;
            btnBlanco.Text = contadorMiliSegundo.ToString();
   
            //EVENTO 1 ENCENDIDO VERDE
            if (contadorMiliSegundo < 15)
            {
                pbVerde1.Visible = true;
                pbVerde4.Visible = true;

            }

            //EVENTO 2 PARPADEO VERDE
            if (contadorMiliSegundo > 14.5 & contadorMiliSegundo < 18.5) 
            {
                if (intermitente)
                {
                    pbVerde1.Visible = true;
                    pbVerde4.Visible = true;
                    intermitente = false;
                }
                else
                {
                    pbVerde1.Visible = false;
                    pbVerde4.Visible = false;
                    intermitente = true;
                }
            }

            //EVENTO 3 Amarillo
            if (contadorMiliSegundo == 18.5)
            {
               pbVerde1.Visible = false;
               pbVerde4.Visible = false;

            }

            if(contadorMiliSegundo > 18.5 & contadorMiliSegundo < 21.5)
            {
                pbAmarillo1.Visible = true;
                pbAmarillo4.Visible = true;

            }

            //EVENTO 4 Rojo
            if (contadorMiliSegundo == 21.5)
            {
                pbAmarillo1.Visible = false;
                pbAmarillo4.Visible = false;

            }

            if (contadorMiliSegundo > 21.5 & contadorMiliSegundo < 24)
            {
                pbRojo1.Visible = true;
                pbRojo4.Visible = true;

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
            timer1.Start();
            timer2.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {

            Reiniciar();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

        }


        int contador = 1;
        int contadorParpadeo = 1;
        int contadorAmarillo = 1;
        int contadorRojo = 1;

        //TIMMER 2 CAMBIA LOS NUMEROS EN LOS DIPLAY DE COLORES
        private void timer2_Tick(object sender, EventArgs e)
        {
            contador = contador + 1;

            //DISPLAY VERDE
            if (contador <= 15)
            {
                btnVerde.Text = contador.ToString();
            }

            //PARPADEO
            if(contador> 15 & contador < 19)
            {
                btnVerde.Text = contadorParpadeo.ToString();
                contadorParpadeo = contadorParpadeo + 1;
            }

            //DISPLAY AMARILLO
            if (contador >=19 & contador < 22)
            {
                btnVerde.Text = "";
                btnAmarillo.Text = contadorAmarillo.ToString();
                contadorAmarillo = contadorAmarillo + 1;
            }

            //DISPLAY ROJO
            if (contador >= 22 & contador < 24)
            {
                btnAmarillo.Text = "";
                btnRojo.Text = contadorRojo.ToString();
                contadorRojo = contadorRojo + 1;
            }

            if (contador == 24) 
            {
                Reiniciar();
            }

        }

        private void btnPreventiva_Click(object sender, EventArgs e)
        {
            Reiniciar();
            timer1.Stop();
            timer2.Stop();
            timer3.Start();
            btnVerde.Text = "";
        }

        
        private void timer3_Tick(object sender, EventArgs e)
        {


            if (intermitente)
            {
                pbAmarillo1.Visible = true;
                pbAmarillo2.Visible = true;
                pbAmarillo3.Visible = true;
                pbAmarillo4.Visible = true;

                intermitente = false;
                btnAmarillo.Text = 0.ToString();
   


            }
            else
            {
                pbAmarillo1.Visible = false;
                pbAmarillo2.Visible = false;
                pbAmarillo3.Visible = false;
                pbAmarillo4.Visible = false;

                intermitente = true;
                btnAmarillo.Text = "";
            }
        }
    }
}
