using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Sunrise2._0.Areas.Identity.Data;

namespace Sunrise2._0.Storage.Entity
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TourId { get; set; }
        [ForeignKey(nameof(TourId))]
        public Tour Tour { get; set; }

        [Required]
        public string ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }



        public int AirlineId { get; set; }
        [ForeignKey(nameof(AirlineId))]
        public Airline Airline{ get; set; }

        public DateTime DateDep { get; set; }




        public bool Wifi { get; set; }

        [Required]
        public int Adults { get; set; }

        [Required]
        public int Children { get; set; }

        [Required]
        public int Nights { get; set; }

        [Required]
        public bool Meals { get; set; }


        [Required]
   
        public DateTime Date { get; set; }


        [Required]
        public int Price { get; set; }
    }
}
