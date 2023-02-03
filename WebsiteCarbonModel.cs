using System;

namespace WebsiteCarbonModel
{
    public class CarbonFootprint
    {
        public string Url { get; set; }
        public bool Green { get; set; }
        public int Bytes { get; set; }
        public double CleanerThan { get; set; }
        public CarbonStatistics Statistics { get; set; }
        public long Timestamp { get; set; }
    }

    public class CarbonStatistics
    {
        public double AdjustedBytes { get; set; }
        public double Energy { get; set; }
        public CarbonEmissions Co2 { get; set; }
    }

    public class CarbonEmissions
    {
        public CarbonGrid Grid { get; set; }
        public CarbonRenewable Renewable { get; set; }
    }

    public class CarbonGrid
    {
        public double Grams { get; set; }
        public double Litres { get; set; }
    }

    public class CarbonRenewable
    {
        public double Grams { get; set; }
        public double Litres { get; set; }
    }
}
