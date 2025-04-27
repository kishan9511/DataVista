using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVista.Utility;

public class COMMON_CLASS
{

    public static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

    #region--Global Date Time--

    public static DateTime GlobalDateTime()
    {
        DateTime IndianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);
        return IndianTime;
    }


    #endregion

    #region--Global Date--
    public static DateTime GlobalDate()
    {
        DateTime IndianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);
        return IndianTime.Date;
    }
    #endregion

    #region--Global Time--
    public static TimeSpan GlobalTime()
    {
        DateTime IndianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);
        TimeSpan timee = IndianTime.TimeOfDay;
        return timee;
    }

    #endregion





}
