using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChaniOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void PocessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amout <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amout = req.Amout.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme İşlei Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amout = req.Amout.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi, Müşterinin Günlük Maksimum Çekebileceği Tutar 400.000₺ olup daha fazlası için birden fazla gün şubeye gelmesi gerekli...";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                
            }
        }

    }
}
