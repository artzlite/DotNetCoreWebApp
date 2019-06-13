using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreWebAppBasic.DAL;
using NetCoreWebAppBasic.Models.PagingList;
using ReflectionIT.Mvc.Paging;

namespace NetCoreWebAppBasic.Controllers
{
    public class TestPagingController : Controller
    {
        private readonly LNAContext _context;
        public TestPagingController(LNAContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int pageIndex = 1, string sortExpression = "DistrictNameThai")
        {
            var datas = _context.TbMasterDistrict.AsNoTracking();
            var model = await PagingList.CreateAsync(datas, 10, pageIndex, sortExpression, "DistrictNameThai");
            model.PageParameterName = "pageIndex";
            model.SortExpressionParameterName = "sortExpression";
            return View(model);
        }
    }
}