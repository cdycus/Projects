//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CD.Telerik.Classes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meeting
    {
        public Meeting()
        {
            this.MeetingAttendees = new HashSet<MeetingAttendee>();
            this.Meetings1 = new HashSet<Meeting>();
        }
    
        public int MeetingID { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> RoomID { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
        public string RecurrenceException { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }
    
        public virtual ICollection<MeetingAttendee> MeetingAttendees { get; set; }
        public virtual ICollection<Meeting> Meetings1 { get; set; }
        public virtual Meeting Meeting1 { get; set; }
    }
}
