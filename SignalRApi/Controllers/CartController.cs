using BusinessLayerSR.Abstract;
using DataAccessLayerSR.Concrete;
using DtoLayerSR.CartDto;
using EntityLayerSR.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpGet]
        public IActionResult GetCartByMenuTableID(int id)
        {
            var values = _cartService.TGetCartByMenuTableNumber(id);
            return Ok(values);
        }
        [HttpGet("CartListByMenuTableWithProductName")]
        public IActionResult CartListByMenuTableWithProductName(int id)
        {
            using var context = new SignalRContext();
            var values = context.Carts.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new ResultCartListWithProducts
            {
                CartID = z.CartID,
                Count = z.Count,
                MenuTableID = z.MenuTableID,
                Price = z.Price,
                ProductID = z.ProductID,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName
            }).ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCart(CreateCartDto createCartDto)
        {
            //Bahçe 01 --> 45
            using var context = new SignalRContext();
            _cartService.TAdd(new Cart()
            {
                ProductID = createCartDto.ProductID,
                Count = 1,
                MenuTableID = 4,
                Price = context.Products.Where(x => x.ProductID == createCartDto.ProductID).Select(y => y.ProductPrice).FirstOrDefault(),
                TotalPrice = 0
            });
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCart(int id)
        {
            var value = _cartService.TGetById(id);
            _cartService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }
    }
}
