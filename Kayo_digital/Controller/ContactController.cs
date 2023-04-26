//using Kayo_digital.Model;
//using Microsoft.AspNetCore.Mvc;
//using Umbraco.Cms.Core.Cache;
//using Umbraco.Cms.Core.Logging;
//using Umbraco.Cms.Core.Routing;
//using Umbraco.Cms.Core.Services;
//using Umbraco.Cms.Core.Web;
//using Umbraco.Cms.Infrastructure.Persistence;
//using Umbraco.Cms.Web.Common.Controllers;
//using Umbraco.Cms.Web.Common.ModelBinders;
//using Umbraco.Cms.Web.Common.Models;
//using Umbraco.Cms.Web.Website.Controllers;

//namespace MyFirstForm.Controllers
//{
//    public class ContactFormController :SurfaceController
//    {
//        public ContactFormController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
//        {
//        }

//        [HttpPost]
//        public IActionResult Submit([ModelBinder(typeof(HttpRequestModelBinder))] ContactFormViewModel model)
//        {
//            if (!ModelState.IsValid)
//                return CurrentUmbracoPage();

//            // Work with form data here

//            return RedirectToCurrentUmbracoPage();
//        }
//    }
//}