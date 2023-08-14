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
    public partial class Form1 : Form
    {

        Eventos eve;
        public Form1()
        {
            InitializeComponent();
            eve = new Eventos();
        }//Fim do Construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }//Tela

        private void button1_Click(object sender, EventArgs e)
        {
            
            eve.Show();


        }//Botão para continuar
    }//Fim da classe
}//Fim do Projeto
