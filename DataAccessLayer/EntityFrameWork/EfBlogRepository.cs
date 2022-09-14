using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c = new Context())
            {
                //ınclude içine hangi entity dahil edilecekse onu yazıyoruz.
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
