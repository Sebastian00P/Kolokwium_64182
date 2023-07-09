using System.ComponentModel.DataAnnotations;

namespace kolokwium.Models
{
    public class RoomType
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
