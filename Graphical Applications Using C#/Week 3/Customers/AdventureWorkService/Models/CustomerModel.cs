using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorkService.Models
{
    [Table("Customer", Schema = "SalesLT")]
    public class CustomerModel
    {
        [Key]
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
    }
}
