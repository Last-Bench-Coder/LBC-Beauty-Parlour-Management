using LBC.Beauty.Parlour.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Interfaces
{
    public interface  ISecQuestRepository
    {
        IEnumerable<SecurityQuestion> GetAllSecurityQuestion();
        SecurityQuestion GetSecurityQuestionById(int SecurityQuestionId);
        void InsertSecurityQuestion(SecurityQuestion entity);
        void BulkInsertSecurityQuestion(IEnumerable<SecurityQuestion> entities);
        void RemoveSecurityQuestion(SecurityQuestion entity);
        void BulkRemoveSecurityQuestion(IEnumerable<SecurityQuestion> entities);
        public void UpdateSecurityQuestion(SecurityQuestion entity);
        public void BulkUpdateSecurityQuestion(IEnumerable<SecurityQuestion> entities);
    }
}
