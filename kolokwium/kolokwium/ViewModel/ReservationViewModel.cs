using kolokwium.Models;
using System.Collections.Generic;

namespace kolokwium.ViewModel
{
    public class ReservationViewModel
    {
        public Reservation Reservation { get; set; }
        public List<RoomType> RoomTypes { get; set; }
        
    }
}
