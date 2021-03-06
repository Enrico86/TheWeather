﻿using NodaTime;
using NodaTime.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TheWeather.Model
{

    public class WeatherData
    {
        public Datum[] data { get; set; }
        public float count { get; set; }
    }

    public class Datum
    {
        private DateTime sunset1;
        private DateTime sunrise1;

        public float rh { get; set; }
        public string pod { get; set; }
        public float lon { get; set; }
        public float pres { get; set; }
        public string timezone { get; set; }
        public string ob_time { get; set; }
        public string country_code { get; set; }
        public float clouds { get; set; }
        public float ts { get; set; }
        public float solar_rad { get; set; }
        public string state_code { get; set; }
        public string city_name { get; set; }
        public float wind_spd { get; set; }
        public DateTime last_ob_time { get; set; }
        public string wind_cdir_full { get; set; }
        public string wind_cdir { get; set; }
        public float slp { get; set; }
        public float vis { get; set; }
        public float h_angle { get; set; }
        public DateTime sunset
        {
            get
            {
                sunset1 = sunset1.AddHours(2);
                return sunset1;
            }

            set
            {
                sunset1 = value;
            }
        }
        public float dni { get; set; }
        public float dewpt { get; set; }
        public float snow { get; set; }
        public float uv { get; set; }
        public float precip { get; set; }
        public float wind_dir { get; set; }
        public DateTime sunrise { get 
            {
                sunrise1 = sunrise1.AddHours(2);
                return sunrise1; 
            } 
            set => sunrise1 = value; }
        public float ghi { get; set; }
        public float dhi { get; set; }
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
