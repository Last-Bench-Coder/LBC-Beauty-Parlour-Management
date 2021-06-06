using LBC.Beauty.Parlour.Management.DataAccess.AppData;
using LBC.Beauty.Parlour.Management.Domain.Entities;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.Repositories
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(AppDbContext context) : base(context)
        {
        }

        public void BulkInsertAdmin(IEnumerable<Admin> entities)
        {
            _context.Administrators.AddRange(entities);
        }

        public void BulkRemoveAdmin(IEnumerable<Admin> entities)
        {
            _context.Administrators.RemoveRange(entities);
        }

        public void BulkUpdateAdmin(IEnumerable<Admin> entities)
        {
            _context.Administrators.UpdateRange(entities);
        }

        public Admin GetAdminById(int adminId)
        {
            return _context.Administrators.FirstOrDefault(d => d.AdminId==adminId);
        }

        public IEnumerable<Admin> GetAllAdministrators()
        {
            return _context.Administrators.OrderByDescending(d => d.EmailId).ToList();
        }

        public void InsertAdmin(Admin admin)
        {
            _context.Administrators.Add(admin);
        }

        public void RemoveAdmin(Admin entity)
        {
            _context.Administrators.Remove(entity);
        }

        public void UpdateAdmin(Admin entity)
        {
            _context.Administrators.Update(entity);
        }
    }
}
