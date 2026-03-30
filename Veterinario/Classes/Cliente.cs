using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Veterinario.Classes
{
    internal class Cliente
    {
        public string Nome { get; set; }

        private int NIF;

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Morada { get; set; }

        public Cliente(string nome, int nif, string telefone, string email, string morada)
        {
            Nome = nome;
            NIF = nif;
            Telefone = telefone;
            Email = email;
            Morada = morada;
        }

        public string GetTelefone()
        {
            if (Telefone.Length == 9 && Telefone.All(char.IsDigit))
                return Telefone;
            else
                return "Número de telefone inválido";
        }

        public string GetEmail()
        {
            if (Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return Email.ToLower();
            else
                return "Endereço de email inválido";
        }
    }
}
