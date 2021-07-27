using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RosterChallenge.ContextClasses;

namespace RosterChallenge.Models
{
    public class RosterModel
    {
        public RosterModel(RosterContext rc)
        {
            Roster  = rc.Artists.ToList().OrderBy(r => r.getTotalPayout());         
        }

        public IOrderedEnumerable<Artist> Roster;
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
        private int months => ((endDate.Year - startDate.Year) * 12) + endDate.Month - startDate.Month;

        //assumes all artists started streaming in 2006, would need to some how track date added to spotify otherwise, which isnt provided in
        //the original data so i assume monthly avg might be wrong for artists added to spotify after this date
        public double getAverageMonthlyPayout() => Math.Round(getTotalPayout() / months, 2);
        public double getTotalPayout() => Math.Round(rate * streams, 2);
    }
}
