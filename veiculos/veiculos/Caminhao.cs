using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculos
{
    internal class Caminhao : Veiculo
    {

        private string cabine;
        private string porte;
        private int eixos;


        public Caminhao()
        {
            this.cabine = null;
            this.porte = null;
            this.eixos = 0;
        }

        public Caminhao(string cabine, string porte, int eixos, string marca, int passageiros, int chassi, string modelo, string placa)
        {
            this.cabine = cabine;
            this.porte = porte;
            this.eixos = eixos;

            this.Marca = marca;
            this.Passageiros = passageiros;
            this.Chassi = chassi;
            this.Modelo = modelo;
            this.Placa = placa;
        }

        public string Cabine
        {
            get { return this.cabine; }
            set { this.cabine = value; }
        }

        public string Porte
        {
            get { return this.porte; }
            set { this.porte = value; }
        }

        public int Eixos
        {
            get { return this.eixos; }
            set { this.eixos = value; }
        }

        public override String Aparece()
        {
            String s = String.Empty;

            s = String.Concat("Marca: ", this.Marca, "\r\n",
                              "Passageiros: ", this.Passageiros.ToString(), "\r\n",
                              "Chassi: ", this.Chassi.ToString(), "\r\n",
                              "Modelo: ", this.Modelo, "\r\n",
                              "Placa: ", this.Placa, "\r\n",
                              "Tipo de Cabine: ", this.Cabine, "\r\n",
                              "Porte: ", this.Porte, "\r\n",
                              "Eixos: ", this.Eixos.ToString());
            return s;

        }

    }

}
