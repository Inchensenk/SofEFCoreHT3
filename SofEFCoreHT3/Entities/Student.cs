using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_HW2.Entities
{
    public class Student
    {
        
        public int Id { get; set; }
       
        public string FirstName { get; set; } = null!;
        
        public string LastName { get; set; } = null!;
        
        public DateTime BirthDate { get; set; }
        
        public string PhoneNumber { get; set; } = null!;
        /// <summary>
        /// Навигационное свойство
        /// </summary>
        public Card? Card { get; set; }
    }
}
