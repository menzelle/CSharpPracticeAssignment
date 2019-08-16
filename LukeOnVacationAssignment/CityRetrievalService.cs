﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace LukeOnVacationAssignment
{
    class CityRetrievalService
    {

        public NameValueCollection GetCities()
        {
            NameValueCollection allCities;
            allCities = ConfigurationManager.AppSettings;
            return allCities;
        }
        public string GetCity(string _city)
        {
            string city = ConfigurationManager.AppSettings.Get(_city);
            return city;
        }

    }
}
