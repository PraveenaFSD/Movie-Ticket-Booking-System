using Mapper.Interfaces;
using Models.Entity;
using Models.Models;
using Models.Request;
using Models.View;


namespace Mapper.Implemenations
{
    public class BusinessLayerMapper : IBusinessLayerMapper
    {
        public async Task<Booking> BookingRequestToBooking(BookingRequest bookingRequest)
        {
            Booking booking=new Booking();
            booking.ShowtimeID = bookingRequest.ShowtimeID;
            booking.BookingDate = DateTime.Today;
            booking.UserName = bookingRequest.UserName;
            booking.Email = bookingRequest.Email;
            booking.PhoneNumber = bookingRequest.PhoneNumber;
            booking.NoOfSeats = bookingRequest.NoOfSeats;
            return booking;
        }

        public async Task<LocationDatasView> LocationToLocationDatasView(Location location)
        {
            LocationDatasView locationView = new LocationDatasView();
            locationView.UID = location.UID;
            locationView.Name = location.Name;
            return locationView;
        }

            public async Task<LocationsView> LocationToLocationsView(Location location)
        {

            LocationsView locationView = new LocationsView();
            locationView.UID = location.UID;
            locationView.Name = location.Name;
            return locationView;
        }

       

        public async Task<MovieView> MovieToMovieView(Movie movie)
        {
            MovieView movieView = new MovieView();
            movieView.UID = movie.UID;
            movieView.Title = movie.Title;
            movieView.Language = movie.Language;
            movieView.Genre = movie.Genre;
            movieView.ReleaseDate = movie.ReleaseDate;
            movieView.Duration = movie.Duration;
            movieView.Description = movie.Description;
            movieView.Likes = movie.Likes;
            movieView.Image=movie.Image;
            movieView.Certification= movie.Certification;
            return movieView;
        }

        public async  Task<SeatDetailsView> SeatDetailsToSeatDetailsView(SeatDetails seatDetails)
        {
            SeatDetailsView seatDetailsView = new SeatDetailsView();    
            seatDetails.UID = seatDetails.UID;
            seatDetailsView.ShowTimeID = seatDetails.ShowTimeID;
            seatDetailsView.SeatNumber = seatDetails.SeatNumber;
            seatDetailsView.IsAvailable = seatDetails.IsAvailable;
            return seatDetailsView;

        }
    }
}