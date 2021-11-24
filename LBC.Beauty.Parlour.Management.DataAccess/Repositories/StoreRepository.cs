using LBC.Beauty.Parlour.Management.DataAccess.AppData;
using LBC.Beauty.Parlour.Management.Domain.Entities;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(AppDbContext context) : base(context)
        {
        }

        public void BulkInsertStore(IEnumerable<Store> entities)
        {
            _context.Store.AddRange(entities);
        }

        public void BulkRemoveStore(IEnumerable<Store> entities)
        {
            _context.Store.RemoveRange(entities);
        }

        public void BulkUpdateStore(IEnumerable<Store> entities)
        {
            _context.Store.UpdateRange(entities);
        }

        public Store GetStoreById(int StoreId)
        {
            return _context.Store.FirstOrDefault(d => d.StoreId==StoreId);
        }

        public IEnumerable<Store> GetAllStore()
        {
            return _context.Store.OrderByDescending(d => d.Name).ToList();
        }

        public void InsertStore(Store Store)
        {
            _context.Store.Add(Store);
        }

        public void RemoveStore(Store entity)
        {
            _context.Store.Remove(entity);
        }

        public void UpdateStore(Store entity)
        {
            _context.Store.Update(entity);
        }
    }
}
