using LBC.Beauty.Parlour.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Interfaces
{
    public interface IAdminRepository
    {
        IEnumerable<Admin> GetAllAdministrators();
        Admin GetAdminById(int adminId);
        void InsertAdmin(Admin entity);
        void BulkInsertAdmin(IEnumerable<Admin> entities);
        void RemoveAdmin(Admin entity);
        void BulkRemoveAdmin(IEnumerable<Admin> entities);
        public void UpdateAdmin(Admin entity);
        public void BulkUpdateAdmin(IEnumerable<Admin> entities);
    }
}
