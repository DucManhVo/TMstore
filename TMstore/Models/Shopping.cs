using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMstore.Models
{
    public class ShippingDetail
    {
        public int ShippingDetailId { get; set; }
        [Required]
        public Nullable<int> MemberId { get; set; }
        [Required]
        public string Adress { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<decimal> PaymentsMoney { get; set; }
        [Required]
        public string PaymentsType { get; set; }


    }
}