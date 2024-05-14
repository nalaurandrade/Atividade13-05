using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        List<Telefone> ListaDeTelefone = new List<Telefone>();

        public void AdicionarTelefone(Telefone tel)
        {
            ListaDeTelefone.Add(tel);
        }

        public void ImprimirTelefones()
        { 
            foreach (Telefone t in ListaDeTelefone) 
            {
                Console.WriteLine(t.ddd + "-" + t.numero);
            }
        }

    }
}
