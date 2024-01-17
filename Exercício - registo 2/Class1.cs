using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício___registo_2
{
    internal class Utilizador
    {
        public string Nome;
        public string Email;
        public string Password;

        public static List<Utilizador> listautilizadores = new List<Utilizador>();

        public Utilizador(string nome, string email, string password) // Os construtores são tipos especiais de métodos usados ​​para criar e inicializar objetos numa classe. 
        {
            Nome = nome;
            Email = email;
            Password = password;
        }   


        public static void Registar(string nome,string email,string password) 
        {
            Utilizador novoutilizador = new Utilizador(nome,email,password);
            listautilizadores.Add(novoutilizador);
        }
    }       
}
