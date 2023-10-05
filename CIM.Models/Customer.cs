using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIM.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public string CustomerName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        
        public int MaritalStatus { get; set; }
        [Column(TypeName = "VARBINARY(Max)")]
        public byte[]? CustomerPhoto { get; set; }
        public Country Country { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; }
    }
}
