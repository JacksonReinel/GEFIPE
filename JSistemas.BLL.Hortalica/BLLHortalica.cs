using System;
using JSistemas.BLL.Base;

namespace JSistemas.BLL.Hortalica
{
    public static class BLLHortalica
    {
        private static BLLProduto _produto;
        public static BLLProduto Produto
        {
            get
            {
                if (_produto == null)
                { _produto = new BLLProduto(); }
                return _produto;
            }
        }
    }
}
