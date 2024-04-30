using COMP003B.Assignment6.Services;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment6.Controllers
{
    public class LifetimeDemoController : Controller
    {
        // private fields
        private readonly MyTransientServices _transientService1;
        private readonly MyTransientServices _transientService2;
        private readonly MyScopedService _scopedService1;
        private readonly MyScopedService _scopedService2;
        private readonly MySingletonService _singletonService1;
        private readonly MySingletonService _singletonService2;

        // constructor
        public LifetimeDemoController(MyTransientServices transientService1, MyScopedService scopedService1,
            MySingletonService singletonService1, MyTransientServices transientServices2, MyScopedService scopedService2, MySingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientServices2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

        }

        public IActionResult Index()
        {
            ViewData["TransientId1"] = _transientService1.GetUniqueId();
            ViewData["TransientId2"] = _transientService2.GetUniqueId();
            ViewData["ScopedId1"] = _scopedService1.GetUniqueId();
            ViewData["ScopedId2"] = _scopedService2.GetUniqueId();
            ViewData["SingletonId1"] = _singletonService1.GetUniqueId();
            ViewData["SingletonId2"] = _singletonService2.GetUniqueId();

            return View();
        }
    }
}
