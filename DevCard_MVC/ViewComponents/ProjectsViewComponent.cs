using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project (1,"taxi","سفر درون شهری","project-1.jpg","atriya" ),
                new Project (2,"zoodfood","درخواست سریع غذا","project-2.jpg","snapfood" ),
                new Project (3,"web dev","طراحی وب سایت و اپلیکیشن ","project-4.jpg","amirhosein shiri" ),
                new Project (4,"payam bolt","خرید آنلاین پیچ و مهره و ابزار آلات صنعتی","project-6.jpg","payamBolt" ),
            };
            return View("_Projects",projects);
        }
    }
}
