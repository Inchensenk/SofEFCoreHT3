using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities
{
    public class Mark
    {
        
        public int Id { get; set; }
        public double MarkValue { get; set; }


        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }


        public int CardId { get; set; }
        public Card? Card { get; set; }
    }
}
