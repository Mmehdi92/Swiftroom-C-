﻿namespace SwiftRoomAPI.Models.Reservation
{
    public class UpdateReservationDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }
    }
}
