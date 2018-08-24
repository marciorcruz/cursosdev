using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAL.Repositorios;
using Repositorio.Entidades;

namespace Repositorio.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adicionar();

            ExcluirVariosClientes();
        }

        private static void ExcluirVariosClientes()
        {
            using (var repCientes = new ClienteRepositorio())
            {
                new List<Cliente>
                {
                    new Cliente { Nome="Renato Silva", Telefone="(11)5747-4185"},
                    new Cliente { Nome="Renato Souza", Telefone="(11)3504-8003"},
                    new Cliente { Nome="Renato Augusto", Telefone="(11)3205-4590"}
                }.ForEach(repCientes.Adicionar);

                repCientes.SalvarTodos();

                System.Console.WriteLine("Clientes Renato's adicionados.");

                // Lista todos os clientes
                foreach (var c in repCientes.GetAll())
                {
                    System.Console.WriteLine(c.ClienteID + " - " + c.Nome);
                }

                // Excluir vários clientes Renato
                try
                {
                    repCientes.Excluir(c => c.Nome.StartsWith("Renato"));
                    repCientes.SalvarTodos();
                    System.Console.WriteLine("clientes excluidos com sucesso");
                }

                catch (Exception)
                {
                    System.Console.WriteLine("erro ao excluir um cliente");
                }

                System.Console.ReadKey();



                /*
                System.Console.WriteLine("===== clientes cadastrados =====");
                foreach (var c in repCientes.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.ClienteID, c.Nome);
                }

                System.Console.ReadKey();
                */
            }
        }
    }
}
