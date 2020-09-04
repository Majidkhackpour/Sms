using System;
using System.Globalization;
using Services;

namespace Sms
{
    public class DateHelper
    {
        public static DateTime UnixTimestampToDateTime(long unixTimeStamp)
        {
            try
            {
                return (new DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(unixTimeStamp);
            }
            catch (Exception ex)
            {
                return DateTime.MaxValue;
            }
        }
        public static long DateTimeToUnixTimestamp(DateTime idateTime)
        {
            try
            {
                idateTime = new DateTime(idateTime.Year, idateTime.Month, idateTime.Day, idateTime.Hour, idateTime.Minute, idateTime.Second);
                var unixTimeSpan = (idateTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local).ToLocalTime());
                return unixTimeSpan.TotalSeconds.ToString(CultureInfo.InvariantCulture).ParseToLong();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
