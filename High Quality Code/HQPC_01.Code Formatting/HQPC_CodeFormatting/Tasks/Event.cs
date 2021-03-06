﻿
namespace HQPC_CodeFormatting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);
            int byLocation = this.location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string Tostring()
        {
            StringBuilder tostring = new StringBuilder();
            tostring.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            tostring.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                tostring.Append(" | " + this.location);
            }

            return tostring.ToString();
        }
    }
}