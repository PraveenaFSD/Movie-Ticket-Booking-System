using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Request
{
    public class BookingRequest
    {
        public Guid UID { get; set; }
        public Guid MovieID { get; set; }
        public Guid ShowtimeID { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public int NoOfSeats { get; set; }
    }
}
