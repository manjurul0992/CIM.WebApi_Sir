using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIM.Models
{
    public class Country
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName ="NVARCHAR(50)")]
        public string CountryName { get; set; }
        public List<Customer> Customers { get; set; }

    }
}