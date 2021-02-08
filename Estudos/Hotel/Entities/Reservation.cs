using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos.Hotel.Entities.Exceptions;

namespace Estudos.Hotel.Entities
{
    class Reservation
    {
        public int RowNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Reservation() { }

        public Reservation(int rowNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
                throw new DomainException("Check-out date must be after check-in date");

            RowNumber = rowNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;            
        }
        public override string ToString()
        {
            return "\n\rRowNumber: "
                + RowNumber
                + "\n\r"
                + "Check-In: "
                + Checkin
                + "\n\r"
                + "Check-Out: "
                + Checkout
                + "";
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout > now)
                throw new DomainException("Reservation dates for must be future dates");
            if (checkout <= checkin)
                throw new DomainException("Check-out date must be after check-in date");
            Checkin = checkin;
            Checkout = checkout;
        }
    }
}
