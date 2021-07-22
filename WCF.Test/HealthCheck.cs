using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Test
{
    [ServiceContract]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    class HealthCheck
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "GET")]
        public Class2 DoWork()
        {
            return new Class2() { 
                Nome = "Peçanha"
            };
        }
    }
}
