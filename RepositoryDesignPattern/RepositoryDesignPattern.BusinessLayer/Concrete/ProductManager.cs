using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{
	public class ProductManager : GenericManager<Product>, IProductService
	{
		private readonly IProductDal _productDal;

        public ProductManager(IGenericDal<Product> genericDal, IProductDal productDal) : base(genericDal)
        {
            _productDal = productDal;
        }

        public List<Product> TProductListWithCategory()
        {
            return _productDal.ProductListWithCategory();
        }
    }
}
