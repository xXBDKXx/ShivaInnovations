using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShivaInnovations
{
    public partial class Eventos : Form
    {

            PagamentoArana pgtoArana;
            PagamentoHenrique pgtoHenrique;
            PagamentoPenha pgtoPenha;
        public Eventos()
        {
            InitializeComponent();
            pgtoArana = new PagamentoArana();
            pgtoHenrique = new PagamentoHenrique();
            pgtoPenha = new PagamentoPenha();
        }//Fim do Construtor

        private void Eventos_Load(object sender, EventArgs e)
        {

        }//Tela

        private void ComprarArana_Click(object sender, EventArgs e)
        {

            pgtoArana.ShowDialog();

        }//Comprar Arana Botão

        private void ComprarHenrique_Click(object sender, EventArgs e)
        {

            pgtoHenrique.ShowDialog();

        }//Botão Comprar Henrique


        private void ComprarPenha_Click_1(object sender, EventArgs e)
        {

            pgtoPenha.ShowDialog();

        }//Botão Comprar Penha
    }//Fim da classe
}//Fim do Projeto
