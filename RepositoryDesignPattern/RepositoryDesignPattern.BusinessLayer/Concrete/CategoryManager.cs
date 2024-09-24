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
	public class CategoryManager : GenericManager<Category>, ICategoryService
	{
		public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
		{
		}
	}
}
