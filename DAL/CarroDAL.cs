using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarroDAL
    {
        private string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = BDSistemaExemploDAAW; Integrated Security = True";

        public void InserirCarro(Carro objCarro)
        {
            //Método para inserir dados ao banco.

            //Cria um objeto para conexão com o banco de dados.
            SqlConnection conn = new SqlConnection(connectionString);

            //Abrir a conexão com o banco de dados.
            conn.Open();

            //Cria o comando que irá ser executado.
            string sql = "INSERT INTO Carros VALUES (@marca, @modelo, @cor, @ano, @placa)";

            //Criar um objeto do tipo comando do SQL.
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Trocar as váriaveis(@ dos VALUES) por valores inseridos.
            cmd.Parameters.AddWithValue("@marca", objCarro.Marca);
            cmd.Parameters.AddWithValue("@modelo", objCarro.Modelo);
            cmd.Parameters.AddWithValue("@cor", objCarro.Cor);
            cmd.Parameters.AddWithValue("@ano", objCarro.AnoFabricacao);
            cmd.Parameters.AddWithValue("@placa", objCarro.Placa);

            //Executa o comando no banco de dados.
            cmd.ExecuteNonQuery();

            //Fechar a conexão com o banco de dados.
            conn.Close();
        }
    }
}
