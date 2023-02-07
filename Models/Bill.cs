using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MassBill.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [Column(TypeName ="nvarchar(12)")]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Payment Type")]
        public string PaymentType { get; set; }
        [Column(TypeName = "nvarchar(11)")]

        public string Code { get; set; }
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public  DateTime Date { get; set; }
    }
}
