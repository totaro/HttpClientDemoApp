# HttpClientDemoApp
Demo Hub for different coding experiments: HttpClientDemo

C#/ASP.NET MVC Razor pages

<b>HttpClient REST API for 2 different calls:</b> 

- 5 days weatherforecast (weather state, daily low/high degrees) for Helsinki, Finland from https://www.metaweather.com/api/location/565346/

Models:
\HttpClientDemo\Models\WeatherForecastModel.cs
\HttpClientDemo\Models\DayForecastModel.cs

Page/HttpClient: 
\HttpClientDemo\Pages\WeatherData.razor (try..catch response)

BaseAddress configuration for weatherdata (\HttpClientDemo\Startup.cs)

string uri = Configuration.GetValue<string>("MetaAPI");
services.AddHttpClient("meta", c =>
{                
c.BaseAddress = new Uri(uri);
});

BaseAddress name configuration (\HttpClientDemo\appsettings.json)
 "MetaAPI": "https://www.metaweather.com/api/" 

-------------------------------------------------------------------------------------
  
- Current Bitcoin value (Euro, USD, GBP and JPY) currencies with 24 hours volume and change from https://api.coingecko.com/api/
  
Model: \HttpClientDemo\Models\CryptoCurrentModel.cs
Page/HttpClient: \HttpClientDemo\Pages\CryptoData.razor (if..else response) 



<img src="screenshots/screenshot_weather.png">

<img src="screenshots/screenshot_crypto.png">
