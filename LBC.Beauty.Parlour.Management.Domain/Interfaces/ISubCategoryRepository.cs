using LBC.Beauty.Parlour.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Interfaces
{
    public interface ISubCategoryRepository
    {
        IEnumerable<SubCategory> GetAllSubCategory();
        SubCategory GetSubCategoryById(int CategoryId);
        void InsertSubCategory(SubCategory entity);
        void BulkInsertSubCategory(IEnumerable<SubCategory> entities);
        void RemoveSubCategory(SubCategory entity);
        void BulkRemoveSubCategory(IEnumerable<SubCategory> entities);
        public void UpdateSubCategory(SubCategory entity);
        public void BulkUpdateSubCategory(IEnumerable<SubCategory> entities);
    }
}
