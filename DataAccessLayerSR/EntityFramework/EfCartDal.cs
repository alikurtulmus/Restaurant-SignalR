using DataAccessLayerSR.Abstract;
using DataAccessLayerSR.Concrete;
using DataAccessLayerSR.Repositories;
using EntityLayerSR.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerSR.EntityFramework
{
    public class EfCartDal : GenericRepository<Cart>, ICartDal
    {
        public EfCartDal(SignalRContext context) : base(context)
        {
        }

        public List<Cart> GetCartByMenuTableNumber(int id)
        {
            using var context = new SignalRContext();
            var values = context.Carts.Where(x => x.MenuTableID == id).Include(y => y.Product).ToList();
            return values;
        }
    }
}
