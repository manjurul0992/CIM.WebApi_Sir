using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIM.Models
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
     
        [Column(name:"CustomerAddress",TypeName ="NVARCHAR(500)")]
        public string Address { get; set; }
        public Customer Customer { get; set; }
    }
}
