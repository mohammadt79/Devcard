using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        
            var article = new List<Articles>
            {
                new Articles(id:1,title:"مقاله سرطان",description:"نوشتن مقاله هوش مصنوعی راجب سرطان ",image:"blog-post-thumb-1.jpg"),
                new Articles(id:2,title:"مقاله اینترنت اشیا",description:"نوشتن مقاله راجب it ",image:"blog-post-thumb-2.jpg"),
                new Articles(id:3,title:"مقاله It",description:"نوشتن مقاله راجب شبکه ها ",image:"blog-post-thumb-3.jpg"),
                new Articles(id:4,title:"مقاله شبکه",description:"نوشتن مقاله راجب شبکه های کامپیوتر ",image:"blog-post-thumb-4.jpg"),


            };
            return View("_Article",article);
        }
    }
}
