using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario.Classes
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }

        private string Especie;

        private string Raca;

        private int Chip;

        public Animal(string nome, string especie, string raca, int idade, float peso, int chip)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
            Idade = idade;
            Peso = peso;
            Chip = chip;
        }


    }
}
