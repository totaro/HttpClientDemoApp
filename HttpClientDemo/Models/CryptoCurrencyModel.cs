using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HttpClientDemo.Models
{
    

    public class CryptoCurrencyModel
    {
        public double[][] prices { get; set; }
        public float[][] market_caps { get; set; }
        public float[][] total_volumes { get; set; }
    }


}
