﻿using System;

namespace WebAPIWithDocker.Data
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }
    }
}
