using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using FitzroyVisitors.Business;
using FitzroyVisitors.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FitzroyVisitors.Controllers
{
    public class VisitorController : ApiController
    {

        private IFitzroyBusSvc _fitzroyBusSvc;

        public VisitorController(IFitzroyBusSvc fitzroyBusSvc) {
            _fitzroyBusSvc = fitzroyBusSvc;
        }


        [HttpGet]
        [Route("api/GetAdUsers", Name = "GetAdUsers")]
        public List<ADUsers> GetAdUsers()
        {
            
            var result = _fitzroyBusSvc.GetDirectoryUsers();
            return result;
        }

        [HttpPost]
        [Route("api/SaveNewVisistor", Name = "SaveNewVisistor")]
        public void SaveNewVisistor(Visitor vis)
        {
        
            _fitzroyBusSvc.SaveNewVisistor(vis);
          
             return;
        }



        [HttpGet]
        [Route("api/GetVisitorsForSignout", Name = "GetVisitorsForSignout")]
        public List<Visitor> GetVisitorsForSignout()
        {

            var result = _fitzroyBusSvc.GetVisitorsForSignout();
            return result;
        }



    }
}
