using System;
using JSistemas.DAL.Base;

namespace JSistemas.DAL.Hortalica
{
    public static class DALHortalica
    {
        private static DALProduto _produto;
        public static DALProduto Produto
        {
            get
            {
                if (_produto == null)
                { _produto = new DALProduto(); }
                return _produto;
            }
        }
    }
}
