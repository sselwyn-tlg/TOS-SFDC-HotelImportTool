using System;
using System.Collections.Generic;
using System.Text;

namespace DataFeed.HotelImport.Console
{
    class SalesForceSettings
    {
        public string SalesForceApiBaseUrl { get; set; }
        public string SalesForceApiUrl { get; set; }
        public string SalesForceAuthorizationURL { get; set; }
        public string SalesForceClientID { get; set; }
        public string SalesForceClientSecret { get; set; }
        public string SalesForceUserName { get; set; }
        public string SalesForcePassword { get; set; }
    }
}
