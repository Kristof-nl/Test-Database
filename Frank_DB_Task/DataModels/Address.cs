using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Frank_DB_Task.DataModels
{
    public class Address
    {
        [Key]
        public int AdressId { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
    }
}
