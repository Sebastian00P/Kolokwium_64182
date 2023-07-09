using kolokwium.AppContext;
using kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationContext _applicationContext;
        public ReservationService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<List<Reservation>> GetAll()
        {
            return await _applicationContext.Reservations.OrderByDescending(x => x.StarDate).ToListAsync();
        }
        public async Task Create(Reservation reservation)
        {
            _applicationContext.Reservations.Add(reservation);
            await _applicationContext.SaveChangesAsync();
        }
        public List<RoomType> GetAllRooms()
        {
            return _applicationContext.RoomTypes.ToList();
        }
        public async Task Delete(long reservationId)
        {
            var element = await _applicationContext.Reservations.Where(x => x.Id == reservationId).FirstOrDefaultAsync();
            var todaysDate = DateTime.Now;
            if (element.StarDate > DateTime.Now.AddDays(1))
            {
                _applicationContext.Reservations.Remove(element);
                await _applicationContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Data od rezerwacji jest mniejsza od dzisiejszej daty");
            }
        }
    }
}
