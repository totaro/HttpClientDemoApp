using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientDemo.Models
{
    

    public class CryptoCurrentModel
    {
        public Bitcoin? bitcoin { get; set; }
    }

    public class Bitcoin
    {
        public int eur { get; set; }
        public float eur_market_cap { get; set; }
        public float eur_24h_vol { get; set; }
        public float eur_24h_change { get; set; }
        public int gbp { get; set; }
        public float gbp_market_cap { get; set; }
        public float gbp_24h_vol { get; set; }
        public float gbp_24h_change { get; set; }
        public int usd { get; set; }
        public float usd_market_cap { get; set; }
        public float usd_24h_vol { get; set; }
        public float usd_24h_change { get; set; }
        public int jpy { get; set; }
        public float jpy_market_cap { get; set; }
        public float jpy_24h_vol { get; set; }
        public float jpy_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }


}
