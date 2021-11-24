using LBC.Beauty.Parlour.Management.DataAccess.AppData;
using LBC.Beauty.Parlour.Management.Domain.Entities;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.Repositories
{
    public class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(AppDbContext context) : base(context)
        {
        }

        public void BulkInsertSubCategory(IEnumerable<SubCategory> entities)
        {
            _context.SubCategories.AddRange(entities);
        }

        public void BulkRemoveSubCategory(IEnumerable<SubCategory> entities)
        {
            _context.SubCategories.RemoveRange(entities);
        }

        public void BulkUpdateSubCategory(IEnumerable<SubCategory> entities)
        {
            _context.SubCategories.UpdateRange(entities);
        }

        public SubCategory GetSubCategoryById(int SubCategoryId)
        {
            return _context.SubCategories.FirstOrDefault(d => d.SubCategoryId==SubCategoryId);
        }

        public IEnumerable<SubCategory> GetAllSubCategory()
        {
            return _context.SubCategories.OrderByDescending(d => d.Title).ToList();
        }

        public void InsertSubCategory(SubCategory SubCategory)
        {
            _context.SubCategories.Add(SubCategory);
        }

        public void RemoveSubCategory(SubCategory entity)
        {
            _context.SubCategories.Remove(entity);
        }

        public void UpdateSubCategory(SubCategory entity)
        {
            _context.SubCategories.Update(entity);
        }
    }
}
