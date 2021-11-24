using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IAdminRepository Administrators { get; }
        ISecQuestRepository SecurityQuestion { get; }
        ICategoryRepository Category { get; }
        ISubCategoryRepository SubCategory { get; }
        IStoreRepository Store { get; }
        int Complete();
    }
}
