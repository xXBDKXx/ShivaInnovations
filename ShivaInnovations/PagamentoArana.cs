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
    public partial class PagamentoArana : Form
    {
        Pgto pague;
        public PagamentoArana()
        {
            InitializeComponent();
            pague = new Pgto();
        }//Fim do Construtor

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//FIm do CheckBox

        private void Confirmar_Click(object sender, EventArgs e)
        {
            pague.ShowDialog();
        }//Fim do Botão

        private void Voltar_Click(object sender, EventArgs e)
        {
            var form = new Eventos();
            form.Hide();
            var form2 = new Eventos();
            this.Hide();  //vai “esconder” o formulário atual
        }//Voltar botão
    }//Fim da Classe
}//Fim do Prjeto
