using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Veterinario.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }

        private int NIF;

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Morada { get; set; }

        public Cliente(string nome, int nif,string telefone, string email, string morada)
        {
            Nome = nome;
            NIF = nif;
            Telefone = telefone;
            Email = email;
            Morada = morada;
        }

        public static string GetTelefone(string telefone)
        {
            if (telefone.Length == 9 && telefone.All(char.IsDigit))
                return telefone;
            else
                return null;
        }

        public static string GetEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return email.ToLower();
            else
                return null;
        }
    }
}
