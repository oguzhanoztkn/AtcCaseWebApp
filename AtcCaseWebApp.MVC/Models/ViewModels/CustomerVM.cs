using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtcCaseWebApp.MVC.Models.ViewModels
{
    public class CustomerVM
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
