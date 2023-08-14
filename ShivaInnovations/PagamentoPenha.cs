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
    public partial class PagamentoPenha : Form
    {
        Pgto pgto;
        public PagamentoPenha()
        {
            InitializeComponent();
            pgto = new Pgto();
        }// fim do construtor

        private void Confirmar_Click(object sender, EventArgs e)
        {
            pgto.ShowDialog();

        }//Botão comprar Penha

        private void Voltar_Click(object sender, EventArgs e)
        {
            var form = new Eventos();
            form.Hide();
            var form2 = new Eventos();
            this.Hide();  //vai “esconder” o formulário atual
        }//Voltar
    }//fim da classe   
}//fim do projeto
