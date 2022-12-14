using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentACar.Data;

namespace RentACar.Controllers
{
    public class DealerController
    {
        private readonly RentACarDbContext data;

        public DealersController(RentACarDbContext _data)
        {
            data = _data;
        }

        [Authorize]
        public IActionResult Become()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Become(BecomeDealerFormModel dealer)
        {
            var userId = User.Id();

            var userIdAlreadyDealer = data
                .Dealers
                .Any(d => d.UserId == userId);

            if (userIdAlreadyDealer)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(dealer);
            }

            var dealerData = new Dealer
            {
                Name = dealer.Name,
                PhoneNumber = dealer.PhoneNumber,
                UserId = userId
            };

            data.Dealers.Add(dealerData);
            data.SaveChanges();

            TempData[GlobalMessageKey] = "Thank you for becomming a dealer";

            return RedirectToAction("All", "Cars");
        }
    }
}
