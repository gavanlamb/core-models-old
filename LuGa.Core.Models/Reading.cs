using System;

namespace LuGa.Core.Device.Models
{
    public class Reading
    {
        public string DeviceId { get; set; }

        public string ReadingType { get; set; }

        public string Value { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
