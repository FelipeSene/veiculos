using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculos
{
    public abstract class Veiculo
    {

        private string marca;
        private int passageiros;
        private int chassi;
        private string modelo;
        private string placa;


        public Veiculo()
        {
            this.marca = null;
            this.passageiros = 0;
            this.chassi = 0;
            this.modelo = null;
            this.placa = null;
        }

        public Veiculo(string marca, int passageiros, int chassi, string modelo, string placa)
        {
            this.marca = marca;
            this.passageiros = passageiros;
            this.chassi = chassi;
            this.modelo = modelo;
            this.placa = placa;
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public int Passageiros
        {
            get { return this.passageiros; }
            set { this.passageiros = value; }
        }

        public int Chassi
        {
            get { return this.chassi; }
            set { this.chassi = value; }
        }
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }

        }

        public string Placa
        {
            get { return this.placa; }
            set { this.placa = value; }

        }

        public abstract String Aparece();

    }
}
