using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgzamTest.Models
{
    public class TaskModel
    {
        public  int TaskId { get; set; }
        [DisplayName("Szerokość")]
        [Required(ErrorMessage = "Pole Nazwa jest wymagane.")]
        [MaxLength(50)]
        public int Weigh { get; set; }
        [DisplayName("Wysokość")]
        [MaxLength(50)]
        public int Heigh { get; set; }
        
        [DisplayName("Cena")]
        [MaxLength(50)]
        public decimal Price { get; set; }

        [DisplayName("Liczba")]
        [MaxLength(50)]
        public int Number { get; set; }
        public bool Done { get; set; }
    }
}
