using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities
{
    public class Subject
    {
       
        public int Id { get; set; }

        [Required]
        public string SubjectName { get; set; } = null!;

        public int CardId { get; set; }

        public List<Card> Cards { get; set; }

        public List<Mark> Marks { get; set; }

        public Subject()
        {
            Cards= new List<Card>();
            Marks= new List<Mark>();
        }
    }
}
