using EntityLayerSR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerSR.Abstract
{
    public interface ICartService : IGenericService<Cart>
    {
        List<Cart> TGetCartByMenuTableNumber(int id);
    }
}
