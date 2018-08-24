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
        /*static void Main(string[] args)
        {
            Adicionar();
        }

        private static void Adicionar()
        {
            using (var repClientes = new ClienteRepositorio())
            {
                new List<Cliente>
                {
                    new Cliente { Nome="Microsoft", Ativo=true, CNPJ="9394.4343/0001-55", Endereco="1, Microsoft One", Telefone="11574739494"},
                    new Cliente { Nome="Google", Ativo=true, CNPJ="1234.9494/0001-33", Endereco="12, Santa Clara, CA", Telefone="1185858483"},
                    new Cliente { Nome="Oracle", Ativo=true, CNPJ="9876.4433/0002-44", Endereco="54, Santa Monica One", Telefone="4884848592"},
                }.ForEach(repClientes.Adicionar);

                repClientes.SalvarTodos();

                System.Console.WriteLine("Clientes adicionadas com sucesso.");

                System.Console.WriteLine("=======   clientes cadastrados  ========");

                foreach (var c in repClientes.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.ClienteID, c.Nome);
                }

                System.Console.ReadKey();

            }
        }*/

        static void Main(string[] args)
        {
            ExcluirVariosClientes();
        }


        private static void ExcluirVariosClientes()
        {
            using (var repClientes = new ClienteRepositorio())
            {
                new List<Cliente>
                {
                    new Cliente { Nome="Renato Haddad", Telefone="48575757"},
                    new Cliente { Nome="Renato Marcantonio", Telefone="55929292"},
                    new Cliente { Nome="Renato José", Telefone="77565644"},
                }.ForEach(repClientes.Adicionar);

                repClientes.SalvarTodos();
                System.Console.WriteLine("Clientes Renato's adicionados");

                //lista todos os clientes
                foreach (var c in repClientes.GetAll())
                {
                    System.Console.WriteLine(c.ClienteID + " - " + c.Nome);
                }

                //excluir vários clientes Renato
                try
                {
                    repClientes.Excluir(c => c.Nome.StartsWith("Renato"));
                    repClientes.SalvarTodos();
                    System.Console.WriteLine("clientes excluidos com sucesso");
                }
                catch (Exception)
                {
                    System.Console.WriteLine("erro ao excluir um cliente");
                }
                System.Console.ReadKey();
            }
        }
    }
}               