using Domain.PCyP.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PCyP.BLL
{
    public static class CategoryBusiness
    {
        private static List<Category> _categoryList = new List<Category>();
        public static void Add(Category categoria)
        {
        _categoryList.Add(categoria);
        }

        public static List<Category> GetCategoryList()
        {
            return _categoryList;
        }
    }
}
