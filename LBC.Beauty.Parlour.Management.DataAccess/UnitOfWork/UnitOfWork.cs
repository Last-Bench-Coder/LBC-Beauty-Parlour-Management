using LBC.Beauty.Parlour.Management.DataAccess.AppData;
using LBC.Beauty.Parlour.Management.DataAccess.Repositories;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Administrators = new AdminRepository(_context);
            SecurityQuestion = new SecQuestRepository(_context);
            Category = new CategoryRepository(_context);
        }

        public IAdminRepository Administrators { get; }
        public ISecQuestRepository SecurityQuestion { get; }
        public ICategoryRepository Category { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
