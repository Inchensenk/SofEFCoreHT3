using SofEFCoreHT3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW2.Entities
{
    public class Card
    {
        public int Id { get; set; }

        public int SerialNumber { get; set; } 

        public int SubjectId { get; set; }

        /// <summary>
        /// Навигационное свойство
        /// </summary>
        public Student? Student { get; set; }



        public List<Subject> Subjects { get; set; }
        public List<Mark> Marks { get; set;  }
        public Card()
        {
            Subjects = new List<Subject>();
            Marks = new List<Mark>();
        }
    }
}
