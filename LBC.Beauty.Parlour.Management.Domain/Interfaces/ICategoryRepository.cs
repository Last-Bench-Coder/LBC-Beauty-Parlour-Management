using LBC.Beauty.Parlour.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryById(int CategoryId);
        void InsertCategory(Category entity);
        void BulkInsertCategory(IEnumerable<Category> entities);
        void RemoveCategory(Category entity);
        void BulkRemoveCategory(IEnumerable<Category> entities);
        public void UpdateCategory(Category entity);
        public void BulkUpdateCategory(IEnumerable<Category> entities);
    }
}
