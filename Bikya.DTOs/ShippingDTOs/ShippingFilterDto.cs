using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bikya.Data.Models;


namespace Bikya.DTOs.ShippingDTOs
{
    public class ShippingFilterDto
    {
        public ShippingStatus? Status { get; set; }
        public string? Method { get; set; } // في حال أضفت shipping method لاحقًا
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

}
