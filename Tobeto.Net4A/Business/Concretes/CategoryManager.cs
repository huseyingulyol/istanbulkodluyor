﻿using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        List<Category> categories;

        public CategoryManager() { 
            categories = new List<Category>();
        }

        public List<Category> GetAll()
        {
            return this.categories;
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int id)
        {
            categories.Remove(categories.Find(x => x.Id == id));
        }

        public void Update(Category category)
        {
            Category foundCategory = categories.Find(x => x.Id == category.Id);
            foundCategory.Name = category.Name;
            foundCategory.Description = category.Description;

        }

        public Category GetById(int id)
        {
            return categories.Find(x => x.Id == id);
        }
    }
}
