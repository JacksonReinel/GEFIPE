using System;
using JSistemas.DAO.Base;

namespace JSistemas.DAO.Hortalica
{
    public class DAOProduto : DAOBase
    {
        public String Nome { get; set; }
        public Decimal Preco { get; set; }
    }
}
