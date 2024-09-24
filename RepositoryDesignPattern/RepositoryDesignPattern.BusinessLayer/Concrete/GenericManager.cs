using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{
	public class GenericManager<T> : IGenericService<T> where T : class
	{
		private readonly IGenericDal<T> _genericDal;

		public GenericManager(IGenericDal<T> genericDal)
		{
			_genericDal = genericDal;
		}

		public void TDelete(T t)
		{
			_genericDal.Delete(t);
		}

		public T TGetByID(int id)
		{
			return _genericDal.GetByID(id);
		}

		public List<T> TGetList()
		{
			return _genericDal.GetList();
		}

		public void TInsert(T t)
		{
			_genericDal.Insert(t);
		}

		public void TUpdate(T t)
		{
			_genericDal.Update(t);
		}
	}
}
