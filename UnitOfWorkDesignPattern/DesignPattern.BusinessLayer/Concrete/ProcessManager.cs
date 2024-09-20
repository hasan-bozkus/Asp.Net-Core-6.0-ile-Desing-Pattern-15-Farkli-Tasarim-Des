using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class ProcessManager : IProcessService
    {

        private readonly IProcessDal _processDal;
        private readonly IUowDal _uowDal;

        public ProcessManager(IProcessDal processDal, IUowDal uowDal)
        {
            _processDal = processDal;
            _uowDal = uowDal;
        }

        public void TDelete(Process t)
        {
            throw new NotImplementedException();
        }

        public Process TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Process> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Process t)
        {
            throw new NotImplementedException();
        }

        public void TMultiUpdate(List<Process> t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Process t)
        {
            throw new NotImplementedException();
        }
    }
}
