using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Entities
{
    public class SecurityQuestion
    {
        [Key]
        public int SecQuestId { get; set; }
        public string SecQuestion { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
