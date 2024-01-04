﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.DAO;
using Microsoft.EntityFrameworkCore;

namespace Library.Business
{
    internal class ReservationManager
    {
        private readonly ReservationDAO _reservationDAO;
        public ReservationManager(ReservationDAO reservationDAO)
        {
            _reservationDAO = reservationDAO;
        }
        public void AddReservation(Reservation reservation)
        {
            _reservationDAO.AddReservation(reservation);
        }
        public Reservation GetReserationByID(int id)
        {
            return _reservationDAO.GetReserationByID(id);
        }
    }
}
