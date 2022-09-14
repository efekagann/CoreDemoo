using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName="Kağan"
                },
                new UserComment {
                    Id=2,
                    UserName="Okan"
                },
                new UserComment {
                    Id=3,
                    UserName="Müjdat"
                }
            };
            return View(commentValues);
        }
    }
}
