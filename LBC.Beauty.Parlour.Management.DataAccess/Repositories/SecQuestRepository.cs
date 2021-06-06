using LBC.Beauty.Parlour.Management.DataAccess.AppData;
using LBC.Beauty.Parlour.Management.Domain.Entities;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LBC.Beauty.Parlour.Management.DataAccess.Repositories
{
    public class SecQuestRepository : GenericRepository<SecurityQuestion>, ISecQuestRepository
    {
        public SecQuestRepository(AppDbContext context) : base(context)
        {
        }

        public void BulkInsertSecurityQuestion(IEnumerable<SecurityQuestion> entities)
        {
            _context.SecurityQuestions.AddRange(entities);
        }

        public void BulkRemoveSecurityQuestion(IEnumerable<SecurityQuestion> entities)
        {
            _context.SecurityQuestions.RemoveRange(entities);
        }

        public void BulkUpdateSecurityQuestion(IEnumerable<SecurityQuestion> entities)
        {
            _context.SecurityQuestions.UpdateRange(entities);
        }

        public SecurityQuestion GetSecurityQuestionById(int SecurityQuestionId)
        {
            return _context.SecurityQuestions.FirstOrDefault(d => d.SecQuestId==SecurityQuestionId);
        }

        public IEnumerable<SecurityQuestion> GetAllSecurityQuestion()
        {
            return _context.SecurityQuestions.OrderByDescending(d => d.SecQuestion).ToList();
        }

        public void InsertSecurityQuestion(SecurityQuestion SecurityQuestion)
        {
            _context.SecurityQuestions.Add(SecurityQuestion);
        }

        public void RemoveSecurityQuestion(SecurityQuestion entity)
        {
            _context.SecurityQuestions.Remove(entity);
        }

        public void UpdateSecurityQuestion(SecurityQuestion entity)
        {
            _context.SecurityQuestions.Update(entity);
        }
    }
}
