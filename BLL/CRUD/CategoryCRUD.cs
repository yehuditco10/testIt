﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CRUD
{
    public static class CategoryCRUD
    {
        public static List<Category> GetAllCategories(checkTestEntities1 ctx)
        {
            return ctx.Categories.ToList();
        }
    }
}
