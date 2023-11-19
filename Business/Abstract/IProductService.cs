using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IProductService
    {
        // 1. Tüm ürünleri getirir.

        IDataResult<List<Product>> GetAll();

        // 2. Belirli bir kategoriye ait tüm ürünleri getirir.

        IDataResult<List<Product>> GetAllByCategoryId(int id);

        // 3. Belirli bir fiyat aralığına göre ürünleri getirir.


        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        // 4. Ürün detaylarını içeren özel bir DTO listesini getirir.

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        // 5. Belirli bir ürün ID'sine sahip ürünü getirir.

        IDataResult<Product> GetById(int productId);

        // 6. Yeni bir ürün ekler.

        IResult Add(Product product);
    }
}