using LBC.Beauty.Parlour.Management.DataAccess.AppData;
using LBC.Beauty.Parlour.Management.Domain.Entities;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public void BulkInsertCategory(IEnumerable<Category> entities)
        {
            _context.Categories.AddRange(entities);
        }

        public void BulkRemoveCategory(IEnumerable<Category> entities)
        {
            _context.Categories.RemoveRange(entities);
        }

        public void BulkUpdateCategory(IEnumerable<Category> entities)
        {
            _context.Categories.UpdateRange(entities);
        }

        public Category GetCategoryById(int CategoryId)
        {
            return _context.Categories.FirstOrDefault(d => d.CategoryId==CategoryId);
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _context.Categories.OrderByDescending(d => d.Title).ToList();
        }

        public void InsertCategory(Category Category)
        {
            _context.Categories.Add(Category);
        }

        public void RemoveCategory(Category entity)
        {
            _context.Categories.Remove(entity);
        }

        public void UpdateCategory(Category entity)
        {
            _context.Categories.Update(entity);
        }
    }
}
