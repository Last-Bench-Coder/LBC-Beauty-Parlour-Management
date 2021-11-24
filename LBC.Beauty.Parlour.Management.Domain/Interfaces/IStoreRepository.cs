using LBC.Beauty.Parlour.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Interfaces
{
    public interface IStoreRepository
    {
        IEnumerable<Store> GetAllStore();
        Store GetStoreById(int StoreId);
        void InsertStore(Store entity);
        void BulkInsertStore(IEnumerable<Store> entities);
        void RemoveStore(Store entity);
        void BulkRemoveStore(IEnumerable<Store> entities);
        public void UpdateStore(Store entity);
        public void BulkUpdateStore(IEnumerable<Store> entities);
    }
}
