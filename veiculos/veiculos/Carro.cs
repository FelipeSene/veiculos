using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace veiculos
{
    internal class Carro : Veiculo
    {

        private string carroceria;
        private int porta;
        private int mala;

        public Carro()
        {
            this.carroceria = null;
            this.porta = 0;
            this.mala = 0;
        }

        public Carro(string carroceria, int porta, int mala, string marca, int passageiros, int chassi, string modelo, string placa)
        {
            this.carroceria = carroceria;
            this.porta = porta;
            this.mala = mala;

            this.Marca = marca;
            this.Passageiros = passageiros;
            this.Chassi = chassi;
            this.Modelo = modelo;
            this.Placa = placa;
        }

        public string Carroceria
        {
            get { return this.carroceria; }
            set { this.carroceria = value; }
        }

        public int Porta
        {
            get { return this.porta; }
            set { this.porta = value; }
        }

        public int Mala
        {
            get { return this.mala; }
            set { this.mala = value; }
        }

        public override String Aparece()
        {
            String s = String.Empty;

            s = String.Concat("Marca: ", this.Marca, "\r\n",
                              "Passageiros: ", this.Passageiros.ToString(), "\r\n",
                              "Chassi: ", this.Chassi.ToString(), "\r\n",
                              "Modelo: ", this.Modelo, "\r\n",
                              "Placa: ", this.Placa, "\r\n",
                              "Carroceria: ", this.Carroceria, "\r\n",
                              "Porta: ", this.Porta.ToString(), "\r\n",
                              "Mala: ", this.Mala.ToString());
            return s;

        }

    }

}
