﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.ViewModels
{
    public class ReceiptViewModel
    {
        [DisplayName("Registreringsnummer")]
        public string? RegNbr { get; set; }

        [DisplayName("Färg")]
        public string? Color { get; set; }

        [DisplayName("Märke")]
        public string? Brand { get; set; }

        [DisplayName("Ankomst")]
        public DateTime Arrival { get; set; }

        [DisplayName("Avresa")]
        public DateTime Departure { get; private set; }

        [DisplayName("Parkerad tid")]
        public string DisplayTime { get; private set; }

        [DisplayName("Avgiftsbelagd tid")]
        public int BillableTime { get; private set; }

        public ReceiptViewModel(DateTime arrival, string regNbr, string color, string brand) {
            Arrival = arrival;
            Departure = DateTime.Now;
            RegNbr = regNbr;
            Color = color;
            Brand = brand;

            double elapsedTime = (Departure - Arrival).TotalMinutes;
            BillableTime = (int)Math.Ceiling(elapsedTime / 60);

            int hours = (int)elapsedTime / 60;
            int minutes = (int)(elapsedTime - (hours * 60));
            DisplayTime = String.Format("{0}:{1}", hours, minutes);
        }

    }
}
