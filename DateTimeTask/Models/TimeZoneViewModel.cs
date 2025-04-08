using System.ComponentModel.DataAnnotations;

namespace DateTimeTask.Models
{
    public class TimeZoneViewModel
    {
        public string SelectedTimeZone { get; set; }
        public List<string> TimeZones { get; set; }

        public TimeZoneViewModel()
        {
            TimeZones = TimeZoneInfo.GetSystemTimeZones().Select(tz => tz.Id).ToList();
            SelectedTimeZone = TimeZoneInfo.Local.Id; // Default to local timezone
        }
    }
}