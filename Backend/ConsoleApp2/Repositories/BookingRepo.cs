using DataLayer.Interfaces;
using Models.Models;
using System.Data.SqlClient;
using System.Data;

public class BookingRepo : IBookingRepo
{
    private readonly IConnection _connection;
    SqlConnection conn;
    public BookingRepo(IConnection connection)
    {
        _connection = connection;
        conn = new SqlConnection(@"Data Source=KANINI-LTP-625\SQLEXPRESS;Integrated Security=true;Initial Catalog=MovieTicket");
    }
    


    public async Task<bool> Add(Booking booking)
    {
        SqlCommand command = null;
        command = new SqlCommand("AddBooking", conn);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@ShowtimeID", booking.ShowtimeID);
        command.Parameters.AddWithValue("@UserName", booking.UserName);
        command.Parameters.AddWithValue("@Email", booking.Email);
        command.Parameters.AddWithValue("@PhoneNumber", booking.PhoneNumber);
        command.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
        command.Parameters.AddWithValue("@NoOfSeats", booking.NoOfSeats);
        conn.Open();
        var result=command.ExecuteNonQuery();
        conn.Close();
        return true; 
        
       
    }
}
