using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMstore.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Mời nhập từ 3 đến 5 ký tự")]
        [StringLength(100, ErrorMessage ="Mời nhập từ 3 đến 100 ký tự", MinimumLength =3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }

    }

    public class ProductDetail
    {
        public int ProductId { get; set; }
        [Required]
        [Range(1,50)]
        public Nullable<int> CategoryId { get; set; }
        [Required(ErrorMessage = "Nhập không đúng quy định")]
        [StringLength(100, ErrorMessage = "Mời nhập từ 3 đến 100 ký tự", MinimumLength = 3)]
        public string ProductName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifieDate { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required]
        [Range(typeof(int),"1","500",ErrorMessage = "Nhập không đúng quy định")]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [Range(typeof(decimal),"1","2000000000", ErrorMessage = "Nhập không đúng quy định")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }
    }
}