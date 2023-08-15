using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShivaInnovations
{
    public partial class Pgto : Form
    {
        DAO conectar;
        
        public Pgto()
        {
            InitializeComponent();
            conectar = new DAO();               //Ligando o Banco de dados a tabela
 
        }//Fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string cpf = maskedTextBox1.Text.Replace(",", "").Replace("-", "");

            // Verificar se todos os dígitos são iguais (CPF inválido)
            if (valid)
            {
                for (byte i = 0; i < 10; i++)
                {
                    var temp = new string(Convert.ToChar(i), 11);
                    if (cpf == temp)
                    {
                        valid = false;
                        break;
                    }// fim do se

                }// fim do para
            }// fim so se

            // verificar os digitos de controle do cpf "00"
            if (valid)
            {
                var j = 0;
                var d1 = 0; // guardar o primeiro digito
                var d2 = 0; // guardar o segundo digito

                // validando o primeiro digito de controle
                for (int i = 10; i > 1; i--)
                {
                    d1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }// fim

                // resto da divisão
                d1 = (d1 * 10) % 11;
                if (d1 == 10)
                {
                    d1 = 0;
                }// fim

                // verificando se o primeiro número e valido
                if (d1 != Convert.ToInt32(cpf.Substring(9, 1)))
                {
                    valid = false;
                }// f im

                // validar segundo número
                j = 0;

                for (int i = 10; i > 1; i--)
                {
                    d2 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }// fim

                // resto da divisão
                d2 = (d2 * 10) % 11;
                if (d2 == 10)
                {
                    d2 = 0;
                }// fim

                // verificando se o primeiro número e valido
                if (d2 != Convert.ToInt32(cpf.Substring(10, 1)))
                {
                    valid = false;
                }// fim
            }
            valid = true;
            


            if ((maskedTextBox1.MaskFull == false) || (valid == false))
            { 

                MessageBox.Show("O campo CPF deve ser preenchido!");
                maskedTextBox1.BackColor = Color.Red;
            }
            else if ((maskedTextBox1.MaskFull == true) && (valid == true))
            {
                try
                {
                    string result = conectar.Inserir(Convert.ToInt64(cpf), nomebox.Text, email.Text, telefone.Text, ingressos.Text, "Cliente");
                    MessageBox.Show(result);
                    MessageBox.Show(cpf);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Algo deu errado\n\n" + erro.Message);
                    MessageBox.Show(cpf);
                }//Fim do TryCatch
            }
        }//Botão comprar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }// cpf

        private void nomebox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// nome

        private void email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// email

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// telefone 

        private void ingressos_ValueChanged(object sender, EventArgs e)
        {

        }// ingressos

        
    }//fim da classe
}//Fim do projeto
