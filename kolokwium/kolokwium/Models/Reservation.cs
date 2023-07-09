using System;
using System.ComponentModel.DataAnnotations;

namespace kolokwium.Models
{
    public class Reservation
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(128)]
        public string Address { get; set; }
        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }
        public int NumberOfPeople { get; set; }
        public bool HasKids { get; set; }
        [Required]
        public DateTime StarDate { get; set; }
        [Required]
        public DateTime EndDate { get; set;}
        public string RoomType { get; set; }
        public int KidsUnderAge { get; set; }
    }
}
