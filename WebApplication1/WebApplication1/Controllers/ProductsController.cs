using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {

        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> products;
            using (var db = new POSEntities())
            {
                products = db.Products.Include(p => p.Maker).ToList();
                return products;
            }
        }

        public Product GetProduct(int id)
        {
            Product product;
            using (var db = new POSEntities())
            {
                product = db.Products.Include(p => p.Maker).FirstOrDefault(p => p.Id.Equals(id))
                return product;
            }
        }
    }
}
