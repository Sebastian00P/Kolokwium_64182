using kolokwium.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace kolokwium.Services
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetAll();
        Task Create(Reservation reservation);
        List<RoomType> GetAllRooms();
        Task Delete(long reservationId);
    }
}