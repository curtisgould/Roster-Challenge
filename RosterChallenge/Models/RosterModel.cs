using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RosterChallenge.Models
{
    public class RosterModel
    {
        public RosterModel()
        {

        }
        public List<Artist> Roster;
    }

    public class Artist
    {
        [Required(ErrorMessage = "ID is required."), Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Artist Name is required.")]
        public string artist { get; set; }

        [Required(ErrorMessage = "Rate is required.")]
        public double rate { get; set; }

        [Required(ErrorMessage = "Total Streams is required.")]
        public int streams { get; set; }

        [Required(ErrorMessage = "Paid is required.")]
        public bool paid { get; set; }

        private DateTime startDate = new DateTime(2006, 4, 1);
        private DateTime endDate = DateTime.Now;
        private int months => ((startDate.Year - endDate.Year) * 12) + startDate.Month - endDate.Month;

        public double getAverageMonthlyPayout() => getTotalPayout() / months;
        public double getTotalPayout() => rate * streams;
    }
}
