using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punteros.UI
{
    public unsafe partial class FrmPunteros : Form
    {
        const int tamañoArray = 5;
        public FrmPunteros()
        {
            InitializeComponent();
        }
        private int* punteroIncrementar;
        private int valorIncrementar = 0;


        private int* punteroArray;

        private unsafe void BtnPosiciones_Click(object sender, EventArgs e)
        {
            CargarPunterosBasicos();
            CargarPunteroParaIncrementar();
            CargarArrayConPuntero();

            btnIncrementar.Enabled = true;
            btnPosiciones.Enabled = false;
        }

        private void CargarPunterosBasicos()
        {
            unsafe
            {
                int* pos1;
                int* pos2;
                int* pos3;
                int* pos4;
                int* pos5;

                int val1 = 10;
                int val2 = 20;
                int val3 = 30;
                int val4 = 40;
                int val5 = 50;

                pos1 = &val1;
                pos2 = &val2;
                pos3 = &val3;
                pos4 = &val4;
                pos5 = &val5;

                lstPosiciones.Items.Add((int)pos1);
                lstPosiciones.Items.Add((int)pos2);
                lstPosiciones.Items.Add((int)pos3);
                lstPosiciones.Items.Add((int)pos4);
                lstPosiciones.Items.Add((int)pos5);

                lstValores.Items.Add(*pos1);
                lstValores.Items.Add(*pos2);
                lstValores.Items.Add(*pos3);
                lstValores.Items.Add(*pos4);
                lstValores.Items.Add(*pos5);
            }
        }

        private unsafe void CargarPunteroParaIncrementar()
        {
            fixed (int* posicionDato = &valorIncrementar)
            {
                punteroIncrementar = posicionDato;
            }

            txtPunteroIncrementar.Text = ((int)punteroIncrementar).ToString();
        }

        public unsafe void Incrementar(int* numero)
        {
            *numero = *numero + 1;
        }

        private unsafe void CargarArrayConPuntero()
        {

            int* datos = stackalloc int[tamañoArray];

            punteroArray = datos;
            for (int i = 0; i < tamañoArray; i++)
            {
                punteroArray[i] = i * 10;
            }

            for (int i = 0; i < tamañoArray; i++)
            {
                lstItemsArray.Items.Add(i);
                lstValorItemArray.Items.Add(punteroArray[i]);
                lstPosicionArray.Items.Add((int)&(punteroArray[i]));
            }
        }
        private void BtnIncrementar_Click(object sender, EventArgs e)
        {
            Incrementar(punteroIncrementar);
            txtPunteroIncrementar.Text = ((int)punteroIncrementar).ToString();
            txtValorIncrementar.Text = (*punteroIncrementar).ToString();
        }

        private unsafe void BtnCopiar_Click(object sender, EventArgs e)
        {
            byte[] origen = Encoding.ASCII.GetBytes(txtCopiarOrigen.Text);
            byte[] destino = new byte[origen.Length];


            Copy(origen, 0, destino, 0, origen.Length);

            txtCopiarDestino.Text = Encoding.ASCII.GetString(destino);
        }

        static unsafe void Copy(byte[] source, int sourceOffset, byte[] target,int targetOffset, int count)
        {
            if ((source == null) || (target == null))
            {
                throw new System.ArgumentException();
            }

            if ((sourceOffset < 0) || (targetOffset < 0) || (count < 0))
            {
                throw new System.ArgumentException();
            }

            if ((source.Length - sourceOffset < count) ||
                (target.Length - targetOffset < count))
            {
                throw new System.ArgumentException();
            }

            fixed (byte* pSource = source, pTarget = target)
            {
                for (int i = 0; i < count; i++)
                {
                    pTarget[targetOffset + i] = pSource[sourceOffset + i];
                }
            }
        }
    }
}
