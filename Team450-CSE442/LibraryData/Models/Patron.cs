using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Has the primary Key 
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryData.Models
{
    public class Patron
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pk { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public string Mode  { get; set; }
        public DateTime DateCompl  { get; set; }
     
    }
}
