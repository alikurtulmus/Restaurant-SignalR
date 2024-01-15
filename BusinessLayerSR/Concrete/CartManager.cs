using BusinessLayerSR.Abstract;
using DataAccessLayerSR.Abstract;
using EntityLayerSR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerSR.Concrete
{
    public class CartManager : ICartService
    {
        private readonly ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void TAdd(Cart entity)
        {
            _cartDal.Add(entity);
        }

        public void TDelete(Cart entity)
        {
            _cartDal.Delete(entity);
        }

        public Cart TGetById(int id)
        {
            return _cartDal.GetByID(id);
        }

        public List<Cart> TGetCartByMenuTableNumber(int id)
        {
            return _cartDal.GetCartByMenuTableNumber(id);
        }

        public List<Cart> TGetListAll()
        {
            return _cartDal.GetListAll();
        }

        public void TUpdate(Cart entity)
        {
            _cartDal.Update(entity);
        }
    }
}
