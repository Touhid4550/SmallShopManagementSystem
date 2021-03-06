﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSMS.DAL.DAL;
using SSMS.Models.Models;

namespace SSMS.BLL.BLL
{
    public class CategoryBll
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        public bool Add(Category category)
        {
            return _categoryRepository.Add(category);
        }
        public bool Update(Category category)
        {
            bool isUpdate = _categoryRepository.Update(category);
            return isUpdate;
        }
        public Category GetCategoryById(string code)
        {
            return _categoryRepository.GetCategoryById(code);
        }

        public bool Delete(Category category)
        {
            bool isDelete = _categoryRepository.Delete(category);
            return isDelete;
        }

        public List<Category> Show(int index)
        {
            return _categoryRepository.Show(index);

        }
    }
}

