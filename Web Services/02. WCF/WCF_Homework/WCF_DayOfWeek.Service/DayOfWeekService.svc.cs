using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_DayOfWeek.Service
{
    using System.Globalization;
    using System.Threading;

    public class DayOfWeekService : IDayOfWeekService
    {

        public string GetDayOfWeek(DateTime date)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            return DateTimeFormatInfo.CurrentInfo.GetDayName( date.DayOfWeek);

        }
    }
}
