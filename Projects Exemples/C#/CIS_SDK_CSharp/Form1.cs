using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace CIS_SDK_CSharp
{
    public partial class Form1 : Form
    {
        [DllImport("CIS_SDK.dll",
                           CallingConvention = CallingConvention.StdCall,
                           CharSet = CharSet.Ansi)]
        public static extern IntPtr CIS_SDK_Versao();

        [DllImport("CIS_SDK.dll",
                           CallingConvention = CallingConvention.StdCall,
                           CharSet = CharSet.Ansi)]  
        public static extern int CIS_SDK_Biometrico_Iniciar();

        [DllImport("CIS_SDK.dll",
                           CallingConvention = CallingConvention.StdCall,
                           CharSet = CharSet.Ansi)]  
        public static extern int CIS_SDK_Biometrico_Finalizar();

        [DllImport("CIS_SDK.dll",
                           CallingConvention = CallingConvention.StdCall,
                           CharSet = CharSet.Ansi)]
        public static extern int CIS_SDK_Biometrico_LerDigital(byte[] Pointer);

        [DllImport("CIS_SDK.dll",
                           CallingConvention = CallingConvention.StdCall,
                           CharSet = CharSet.Ansi)]
        public static extern int CIS_SDK_Biometrico_CancelarLeitura();
    
        [DllImport("CIS_SDK.dll",
                           CallingConvention = CallingConvention.StdCall,
                           CharSet = CharSet.Ansi)]
        public static extern int CIS_SDK_Biometrico_CompararDigital(byte[] Amostra1, byte[] Amostra2);
    
        [DllImport("CIS_SDK.dll",
                           CallingConvention = CallingConvention.StdCall,
                           CharSet = CharSet.Ansi)]
        public static extern IntPtr CIS_SDK_Biometrico_LerDigital_LerWSQ(ref int iRetorno, ref int iSize);

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr str = CIS_SDK_Versao();
            string Result = Marshal.PtrToStringAnsi(str);
            lblVersao.Text = "CIS SDK - v." + Result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iRetorno = CIS_SDK_Biometrico_Iniciar();
                if (iRetorno != 1)
                {
                    string strMensagem = Convert.ToString(iRetorno);
                    MessageBox.Show("Erro Iniciar: " + strMensagem);
                    return;
                }

            btnCancelarLeitura.Enabled = true;

            Thread tLeitura = new Thread(LerDigital1);
            tLeitura.Start();                          
        }

        static void LerDigital1()
        {
            byte[] bArray = new byte[669];
            int iRetorno = CIS_SDK_Biometrico_LerDigital(bArray);
            if (iRetorno != 1)
            {
                CIS_SDK_Biometrico_Finalizar();

                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Leitura: " + strMensagem);
                return;
            }

            Directory.CreateDirectory("C:/CIS_SDK/DIGITAIS");
            File.WriteAllBytes("C:/CIS_SDK/DIGITAIS/Template1.tpl", bArray);

            iRetorno = CIS_SDK_Biometrico_Finalizar();
            if (iRetorno != 1)
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Finalizar: " + strMensagem);
                return;
            }

            MessageBox.Show("Template gerado!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iRetorno = CIS_SDK_Biometrico_Iniciar();
            if (iRetorno != 1)
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Iniciar: " + strMensagem);
                return;
            }

            btnCancelarLeitura.Enabled = true;

            Thread tLeitura = new Thread(LerDigital2);
            tLeitura.Start();                          
        }

        static void LerDigital2()
        {
            byte[] bArray = new byte[669];
            int iRetorno = CIS_SDK_Biometrico_LerDigital(bArray);
            if (iRetorno != 1)
            {
                CIS_SDK_Biometrico_Finalizar();

                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Leitura: " + strMensagem);
                return;
            }

            Directory.CreateDirectory("C:/CIS_SDK/DIGITAIS");
            File.WriteAllBytes("C:/CIS_SDK/DIGITAIS/Template2.tpl", bArray);

            iRetorno = CIS_SDK_Biometrico_Finalizar();
            if (iRetorno != 1)
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Finalizar: " + strMensagem);
                return;
            }

            MessageBox.Show("Template gerado!");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int iRetorno = CIS_SDK_Biometrico_Iniciar();
            if (iRetorno != 1)
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Iniciar: " + strMensagem);
                return;
            }

            byte[] bAmostra1 = new byte[669];
            byte[] bAmostra2 = new byte[669];

            bAmostra1 = File.ReadAllBytes("C:/CIS_SDK/DIGITAIS/Template1.tpl");
            bAmostra2 = File.ReadAllBytes("C:/CIS_SDK/DIGITAIS/Template2.tpl");

            iRetorno = CIS_SDK_Biometrico_CompararDigital(bAmostra1, bAmostra2);
            if (iRetorno == 1)
            {
                MessageBox.Show("As digitais são IGUAIS");
            } else if (iRetorno == -2) 
            {
                MessageBox.Show("As digitais são DIFERENTES");
            }
            else
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Leitura: " + strMensagem);
                return;
            }

            iRetorno = CIS_SDK_Biometrico_Finalizar();
            if (iRetorno != 1)
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Finalizar: " + strMensagem);
                return;
            }
        }

        private void btnCancelarLeitura_Click(object sender, EventArgs e)
        {
            CIS_SDK_Biometrico_CancelarLeitura();

            btnCancelarLeitura.Enabled = false;
        }


        private void btnLerImagemWSQ_Click(object sender, EventArgs e)
        {
            int iRetorno = CIS_SDK_Biometrico_Iniciar();
            if (iRetorno != 1)
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Iniciar: " + strMensagem);
                return;
            }

            btnCancelarLeituraImagem.Enabled = true;

            Thread tLeitura = new Thread(LerImagemWSQ);
            tLeitura.Start();                          
        }


        static void LerImagemWSQ()
        {
            int iRetorno = 0;
            int iSize = 0;
            IntPtr pImagem = CIS_SDK_Biometrico_LerDigital_LerWSQ(ref iRetorno, ref iSize);
            if (iRetorno == 0)
                return;

            if (iRetorno != 1)
            {
                CIS_SDK_Biometrico_Finalizar();

                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Leitura: " + strMensagem);
                return;
            }

            byte[] bArray = new byte[iSize];
            Marshal.Copy(pImagem, bArray, 0, iSize);

            Directory.CreateDirectory("C:/CIS_SDK/IMAGENS");
            File.WriteAllBytes("C:/CIS_SDK/IMAGENS/ImagemWSQ.wsq", bArray);

            iRetorno = CIS_SDK_Biometrico_Finalizar();
            if (iRetorno != 1)
            {
                string strMensagem = Convert.ToString(iRetorno);
                MessageBox.Show("Erro Finalizar: " + strMensagem);
                return;
            }

            MessageBox.Show("Imagem gerada!");
        }

        private void btnCancelarLeituraImagem_Click(object sender, EventArgs e)
        {
            CIS_SDK_Biometrico_CancelarLeitura();

            btnCancelarLeituraImagem.Enabled = false;
        }

        

    }
}
