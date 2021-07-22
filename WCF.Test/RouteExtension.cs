﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace WCF.Test
{
    public static class RouteExtension
    {
        public static void AddRoute()
        {
            RouteTable.Routes.Add(new ServiceRoute("health/", new WebServiceHostFactory(),
                typeof(HealthCheck)));
        }
    }
}
