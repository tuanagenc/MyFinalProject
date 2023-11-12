using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete.InMemory;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<IProduct> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
        }
    }
}
