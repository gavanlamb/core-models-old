using System;

namespace LuGa.Core.Device.Models
{
    public class Event
    {
        public int Id { get; set; }
        
        public string DeviceId { get; set; }
        
        public string Action{ get; set; }
        
        public string Zone{ get; set; }
        
        public string Value{ get; set; }

        public DateTime TimeStamp { get; set; }
    }
}