using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Patron
    {
        public string UserName { get; set; }
        public int Score { get; set; }
        public string Mode  { get; set; }
        public DateTime DateCompl  { get; set; }
        
    }
}
