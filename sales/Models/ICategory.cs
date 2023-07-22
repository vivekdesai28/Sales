﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sales.Models
{
    public interface ICategory
    {
        Category GetCategoryId(int id);
        IEnumerable<Category> GetAllCategory();
        
        bool AddCategory(Category cat);
    }
}
