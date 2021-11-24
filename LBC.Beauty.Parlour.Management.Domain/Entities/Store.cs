using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LBC.Beauty.Parlour.Management.Domain.Entities
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string DateCreated { get; set; }
        public string DateUpdated { get; set; }
        public string Status { get; set; }
    }
}
