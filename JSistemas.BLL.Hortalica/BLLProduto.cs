using System;
using JSistemas.BLL.Base;
using JSistemas.DAO.Hortalica;
using JSistemas.DAL.Hortalica;

namespace JSistemas.BLL.Hortalica
{
    public class BLLProduto : BLLBase
    {
        public void Gravar(DAOProduto produto)
        {
            this.ValidarProduto(produto);
            DALHortalica.Produto.Gravar(produto);

        }

        private void ValidarProduto(DAOProduto produto)
        {
            if (produto == null)
            { throw new NullReferenceException("Produto não pode ser vazio!"); }
            else if (produto.Nome.Trim() == String.Empty)
            { throw new Exception("O nome do produto é obrigatório!"); }
            else if (produto.Preco < 0)
            { throw new Exception("O preço do produto não pode ser menor que zero!"); }
        }
    }
}
