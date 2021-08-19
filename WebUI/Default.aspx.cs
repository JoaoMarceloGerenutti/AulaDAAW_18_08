using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnInserir_Click(object sender, EventArgs e)
        {
            //Converter os dados que o usuario digitou, preencher em um objeto.
            Carro objCarro = new Carro();
            objCarro.Marca = txbMarca.Text;
            objCarro.Modelo = txbModelo.Text;
            objCarro.Cor = txbCor.Text;
            objCarro.AnoFabricacao = Convert.ToInt32(txbAnoFabricacao.Text);
            objCarro.Placa = txbPlaca.Text;

            //Manda o objeto para a camda de banco de dados(DAL).
            CarroDAL cDAL = new CarroDAL();
            cDAL.InserirCarro(objCarro);
        }
    }
}