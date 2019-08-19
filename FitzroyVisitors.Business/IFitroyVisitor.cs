using FitzroyVisitors.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitzroyVisitors.Business
{
    public interface IFitzroyBusSvc
    {
        List<ADUsers> GetDirectoryUsers();
        void SaveNewVisistor(Visitor visitor);
        List<Visitor> GetVisitors();
        List<Visitor> GetVisitorsForSignout();
    }
}
