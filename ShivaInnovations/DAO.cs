using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace ShivaInnovations
{
    class DAO
    {

        public MySqlConnection conexao;
        public long[] CPF;
        public string[] nome;
        public string[] email;
        public string[] telefone;
        public string[] ingressos;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=ShivaInnovations;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão com o banco de dados
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);//Exibir qual foi o erro caso haja um
            }
        }//Fim do Metodo

        public string Inserir(long CPF, string nome, string email, string telefone, string ingressos, string nomeTabela)
        {
            string inserir = $"Insert into {nomeTabela}(CPF, nome, email, telefone, ingressos) values ('{CPF}', '{nome}', '{email}', '{telefone}', '{ingressos}')";//Insert os dados especificados dentro de uma tabela especificada
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";//Ctrl enter no banco basicamente
            return resultado;
        }//Fim do Metodo

    }// fim classe
}// fim projeto 
