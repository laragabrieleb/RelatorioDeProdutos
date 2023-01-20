using Heranca02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos deseja inserir? ");
            int nProdutos = Convert.ToInt32(Console.ReadLine());

            List<Produto> listaProdutos = new List<Produto>();

            for (int i = 0; i < nProdutos; i++)
            {
                Console.WriteLine("O produto é usado ou importado ou comum?  (U / I / C)");
                string importOuUsado = Console.ReadLine();

                switch (importOuUsado.ToUpper())
                {
                    case "U":
                        ProdutoUsado produtoUsado = new ProdutoUsado();
                        Console.WriteLine("Qual o nome do produto? ");
                        produtoUsado.Nome = Console.ReadLine();

                        Console.WriteLine("Preço: ");
                        produtoUsado.Preco = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Data de fabricação: ");
                        produtoUsado.Fabricado = Convert.ToDateTime(Console.ReadLine());

                        listaProdutos.Add(produtoUsado);
                        break;

                    case "I":
                        ProdutoImportado produtoImportado = new ProdutoImportado();
                        Console.WriteLine("Qual o nome do produto? ");
                        produtoImportado.Nome = Console.ReadLine();

                        Console.WriteLine("Qual o preço do produto? ");
                        produtoImportado.Preco = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Qual a taxa do produto? ");
                        produtoImportado.AlfandegaLivre = Convert.ToDouble(Console.ReadLine());

                        listaProdutos.Add(produtoImportado);
                        break;

                    case "C":
                        Produto produto = new Produto();
                        Console.WriteLine("Qual o nome do produto? ");
                        produto.Nome = Console.ReadLine();

                        Console.WriteLine("Qual o preço do produto? ");
                        produto.Preco = Convert.ToDouble(Console.ReadLine());

                        listaProdutos.Add(produto);
                        break;

                    default:
                        break;
                }

            }

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine( produto.PrecoEtiqueta());
            }

            Console.ReadLine();
            
        }
    }
}
