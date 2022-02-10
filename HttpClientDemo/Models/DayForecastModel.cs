using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientDemo.Models
{
    //public class Parent
    //{
    //    public string title { get; set; }
    //    public string location_type { get; set; }
    //    public int woeid { get; set; }
    //    public string latt_long { get; set; }
    //}

    public class DayForecastModel
    {
        //public long id { get; set; }
        public string? weather_state_name { get; set; }
        //public string weather_state_abbr { get; set; }
        //public string wind_direction_compass { get; set; }
        //public DateTime created { get; set; }
        public string? applicable_date { get; set; }
        public float min_temp { get; set; }
        public float max_temp { get; set; }
        //public float the_temp { get; set; }
        //public float wind_speed { get; set; }
        //public float wind_direction { get; set; }
        //public float air_pressure { get; set; }
        //public int humidity { get; set; }
        //public float visibility { get; set; }
        //public int predictability { get; set; }
    }

    //public class Source
    //{
    //    public string title { get; set; }
    //    public string slug { get; set; }
    //    public string url { get; set; }
    //    public int crawl_rate { get; set; }
    //}


}
