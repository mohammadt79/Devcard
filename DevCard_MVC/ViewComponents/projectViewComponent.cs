using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class projectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var pr = new List<project>
            {
                new project(id:1,name:"وبسایت شخصی",description:"پروژه ساخت وبسایت شخصی",image:"assets/images/project/project-3.jpg",client:"snapp"),
                new project(id:2,name: "وبسایت مدارس",description:"پروژه ساخت وبسایت مدارس غیر انتفاعی شمال تهران",image:"assets/images/project/project-4.jpg",client:"school"),
                new project(id:3,name:"وبسایت دیجی کالا",description:"پروژه ساخت وبسایت دیجی کالا",image:"assets/images/project/project-7.jpg",client:"digikala"),
                new project(id:4,name:"وبسایت مگاتک",description:"پروژه ساخت وبسایت مگاتک",image:"assets/images/project/project-5.jpg",client:"Megatech")

            };
            return View("_project",pr);
        }
    }
}
