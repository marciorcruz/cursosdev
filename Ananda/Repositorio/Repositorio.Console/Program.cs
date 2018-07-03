using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAL;
using Repositorio.DAL.Repositorios;
using Repositorio.Entidades;

namespace Repositorio.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Adicionar();
        }

        private static void Adicionar()
        {

            using (var repTipo = new TipodeClienteRepositorio())
            {
                new List<TipodeCliente>
                    {
                        new TipodeCliente { Nome="Físico"},
                        new TipodeCliente { Nome="Jurídico"},
                    }.ForEach(repTipo.Adicionar);

                repTipo.SalvarTodos();
                System.Console.WriteLine("Tipos de cliente adicionados com sucesso!");
                System.Console.WriteLine("========= Tipos de Cliente =========");
                foreach (var c in repTipo.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.TipodeClienteID, c.Nome);
                }

                System.Console.ReadKey();
            }
            using (var repClientes = new ClienteRepositorio())
            {
                new List<Cliente>
                {
                    new Cliente { Nome="Microsoft", Ativo=true, CNPJ="9394.4343/0001-55",
                                    Endereco="1, Microsoft One", Telefone="11574739494"},
                    new Cliente { Nome="Google", Ativo=true, CNPJ="1234.9494/0001-33",
                                    Endereco="12, Santa Clara, CA", Telefone="1185858483"},
                    new Cliente { Nome="Oracle", Ativo=true, CNPJ="9876.4433/0002-44",
                                    Endereco="54, Santa Monica", Telefone="4884848592"}
                }.ForEach(repClientes.Adicionar);

                repClientes.SalvarTodos();

                System.Console.WriteLine("Clientes adicionados com sucesso!");
                System.Console.WriteLine("========= Clientes Cadastrados =========");
                foreach (var c in repClientes.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.ClienteID, c.Nome);
                }

                System.Console.ReadKey();
            }
        }
    }
}
