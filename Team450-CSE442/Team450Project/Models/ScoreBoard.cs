using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team450Project.Models
{
    public class ScoreBoard
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public int Score { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Mode { get; set; }
        public string CompletionTime { get; set; }
        
    }
}
