using System;

namespace crdockerdemo1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}


//kubectl create secret docker-registry helloworldsn --docker-server=helloworldcts.azurecr.io --docker-username=HelloWorldCTS --docker-password=Ntq/WlhUUW31e4Zj39ZgZHhEEI1bAylu --docker-email=shrivallinew @hotmail.com