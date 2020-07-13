﻿using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Telerik.Examples.RazorPages.Models
{
    public class MeetingViewModel : ISchedulerEvent
    {
        public int MeetingID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        private DateTime start;
        [Required]
        public DateTime Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value.ToUniversalTime();
            }
        }

        public string StartTimezone { get; set; }

        private DateTime end;

        [Required]
        [DateGreaterThan(OtherField = "Start")]
        public DateTime End
        {
            get
            {
                return end;
            }
            set
            {
                end = value.ToUniversalTime();
            }
        }

        public string EndTimezone { get; set; }

        public string RecurrenceRule { get; set; }
        public int? RecurrenceID { get; set; }
        public string RecurrenceException { get; set; }
        public bool IsAllDay { get; set; }
        public string Timezone { get; set; }
        public int? RoomID { get; set; }
        public IEnumerable<int> Attendees { get; set; }
    }
}
