﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheWeather.Model
{

    public class WeatherData
    {
        public Datum[] data { get; set; }
        public int count { get; set; }
    }

    public class Datum
    {
        public int rh { get; set; }
        public string pod { get; set; }
        public float lon { get; set; }
        public float pres { get; set; }
        public string timezone { get; set; }
        public string ob_time { get; set; }
        public string country_code { get; set; }
        public int clouds { get; set; }
        public int ts { get; set; }
        public float solar_rad { get; set; }
        public string state_code { get; set; }
        public string city_name { get; set; }
        public int wind_spd { get; set; }
        public DateTime last_ob_time { get; set; }
        public string wind_cdir_full { get; set; }
        public string wind_cdir { get; set; }
        public float slp { get; set; }
        public int vis { get; set; }
        public float h_angle { get; set; }
        public string sunset { get; set; }
        public float dni { get; set; }
        public float dewpt { get; set; }
        public int snow { get; set; }
        public float uv { get; set; }
        public int precip { get; set; }
        public int wind_dir { get; set; }
        public string sunrise { get; set; }
        public float ghi { get; set; }
        public float dhi { get; set; }
        public int aqi { get; set; }
        public float lat { get; set; }
        public Weather weather { get; set; }
        public string datetime { get; set; }
        public float temp { get; set; }
        public string station { get; set; }
        public float elev_angle { get; set; }
        public float app_temp { get; set; }
    }

    public class Weather
    {
        public string icon { get; set; }
        public string code { get; set; }
        public string description { get; set; }
    }

}