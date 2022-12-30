using _12._30.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using X.PagedList;
using System.Data.Entity;

namespace _12._30.Controllers
{
    public class P100_2Controller : Controller
    {
        // GET: P100_2
        public ActionResult Index(int pageNumber=1)
        {
            pageNumber = pageNumber >0 ? pageNumber: 1;

            IPagedList<Product> pagedData = GetPagedProducts(pageNumber);

            return View(pagedData);
        }
        private IPagedList<Product> GetPagedProducts(int pageNumber) 
        {
            var db = new AppDbContext();
            int pageSize = 3;

            var query = db.Products.Include(x => x.Category)
                .OrderBy(x => x.Category.DisplayOrder);

            return query.ToPagedList(pageNumber,pageSize);

        }
    }
}