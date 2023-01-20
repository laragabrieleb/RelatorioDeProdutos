using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca02.Entities
{
    public class ProdutoUsado : Produto
    {
        public DateTime Fabricado { get; set; } = DateTime.Now;

        public ProdutoUsado()
        {

        }

        public ProdutoUsado (DateTime fabricado)
        {
            Fabricado = fabricado;
        }

        public override string PrecoEtiqueta()
        {
            return $"Nome - {Nome} Preço -  R$ {Preco}  Data - {Fabricado}";
        }
    }
}
