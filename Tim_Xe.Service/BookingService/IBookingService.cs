﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tim_Xe.Data.Models;

namespace Tim_Xe.Service.BookingService
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingDTO>> GetAllBookingsAsync(int idDriver, int status);
        Task<double> CaculatorBooking(BookingCreatePriceDTO bookingCreatePriceDTO);
        Task<bool> CreateBooking(BookingCreateDTO bookingCreateDTO);
    }
}
