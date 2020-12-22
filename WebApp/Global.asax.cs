using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Noskaidro tīmekļa lietojumprogrammas failu ceļu:
            string dir = Server.MapPath("~/");
            // No failu ceļa atmet pēdējos divus katalogus "\WebApp\bin\":
            for (int n = 2; n > 0; n--)
                dir = dir.Substring(0, dir.LastIndexOf('\\'));
            // Pievieno projekta DataModel asamblejas katalogu:
            dir = System.IO.Path.Combine(dir, "DataModel");
            // Aktualizē iebūvēto uzstādījumu |DataDirectory|, kas tiek lietota
            // pieslēguma virknē QualificationWorksConnectionString:
            AppDomain.CurrentDomain.SetData("DataDirectory", dir);
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}