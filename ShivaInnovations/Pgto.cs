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
            
            try
            {
                string result = conectar.Inserir(Convert.ToInt64(maskedTextBox1.Text), nomebox.Text, email.Text, telefone.Text, ingressos.Text, "Cliente");
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro.Message);
            }//Fim do TryCatch

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
