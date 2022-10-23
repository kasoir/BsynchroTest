using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public int customerId { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public double balance { get; set; }

        //[NotMapped]
        public int transactions { get; set; }


    }
}
