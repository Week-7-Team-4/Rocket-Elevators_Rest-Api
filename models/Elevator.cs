using System;

namespace Rocket_Elevators_Rest_Api
{
    public class Elevator
    {

        public int Id { get; set; }

        public string serial_number { get; set; }

        public string status { get; set; }

        public DateTime date_last_inspection { get; set; }

        public int column_id { get; set; }
    
    
    }      
}