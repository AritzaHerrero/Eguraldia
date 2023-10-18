namespace Eguraldia.Activities
{
    public class WeatherCode
    {
        public static string Convert(int code) 
        {
            switch (code)
            {
                case 0:
                    return "Clear Sky";
                case 1:
                    return "Mainly Clear";
                case 2:
                    return "Partly Cloudy";
                case 3:
                    return "Overcast";
                case 4:
                    return "Thunderstorm with slight and heavy hail";
                default:
                    return "Unknown";
            }
        }
    }
}
