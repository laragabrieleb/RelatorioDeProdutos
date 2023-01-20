using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca02.Entities
{
    public class ProdutoImportado : Produto
    {
        public double AlfandegaLivre { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(double alfandegaLivre) 
        {
            AlfandegaLivre= alfandegaLivre;
        }

        public double PrecoTotal (double alfandegaLivre, double preco) 
        {
           return alfandegaLivre + preco;
        }

        public override string PrecoEtiqueta()
        {
            return $"Nome - {Nome} Preço -  R$ {Preco}  Taxa - {AlfandegaLivre}";
        }
    }
}
