using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Invent.Models
{
    [Table("Shopkeeper")]
    public class Shopkeeper
    {
        int Amount;

        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Enter Name of the Product")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Enter Price of the Product")]
        public int ProductPrice { get; set; }

        [Required(ErrorMessage = "Enter Quantity of the Product")]
        public int Quantity { get; set; }   
        
        public int amount {

            get { return Amount; }
            set
            {
                if (value == 0)
                {
                    Amount = ProductPrice * Quantity;
                }

                else
                {
                    Amount = value;
                }
            }

        }

        [Required(ErrorMessage = "Enter Purchase Date of the Product")]
        public DateTime Date { get; set; }

    }
}
