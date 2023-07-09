using kolokwium.Models;
using kolokwium.Services;
using kolokwium.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace kolokwium.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _reservationService.GetAll();
            return View(model);
        }
        public IActionResult Create()
        {
            var roomTypes = _reservationService.GetAllRooms();
            var model = new ReservationViewModel() { RoomTypes = roomTypes };
            return View(model);
        }
        public async Task<IActionResult> CreateReservation(Reservation reservation, string roomType)
        {
            reservation.RoomType = roomType;
            await _reservationService.Create(reservation);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(long reservationId)
        {
            await _reservationService.Delete(reservationId);
            return RedirectToAction("Index");
        }
    }
}
