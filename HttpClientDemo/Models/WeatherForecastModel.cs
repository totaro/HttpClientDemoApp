using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HttpClientDemo.Models
{
    //public class WeatherForecastModel
    //{
    //}


    public class WeatherForecastModel
    {
        public DayForecastModel[]? Consolidated_weather { get; set; }
        //public DateTime time { get; set; }
        public DateTime Sun_rise { get; set; } //sunRise -> SunRise
        public DateTime Sun_set { get; set; }
        //public string? timezone_name { get; set; }
        //public Parent? parent { get; set; }
        //public Source[] sources { get; set; }
        public string? Title { get; set; }
        //public string location_type { get; set; }
        //public int woeid { get; set; }
        //public string latt_long { get; set; }
        public string? Timezone { get; set; }
    }

    //public class Source
    //{
    //    public string title { get; set; }
    //    public string slug { get; set; }
    //    public string url { get; set; }
    //    public int crawl_rate { get; set; }
    //}


}
