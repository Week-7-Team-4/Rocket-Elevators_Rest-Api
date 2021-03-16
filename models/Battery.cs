using System;

namespace Rocket_Elevators_Rest_Api
{
    public class Battery
    {
        public int Id { get; set; }

        public string status { get; set; }

        public int building_id { get; set; }

        public int employee_id { get; set; }

    }
}
