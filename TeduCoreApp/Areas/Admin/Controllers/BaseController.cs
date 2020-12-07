using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TeduCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]//bat buoc phai dang nhap
    public class BaseController : Controller
    {
        
    }
}