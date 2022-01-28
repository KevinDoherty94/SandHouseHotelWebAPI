using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolTourWebAPI.Controllers
{
    public class WeatherInfoController : ApiController
    {

        //Below returns an entire record

        //public Activity Get(string activityN)
        //{

        //    //Create an instance of the db context
        //    using (SchoolTourAPIEntities db = new SchoolTourAPIEntities())
        //    {

        //        Activity returnThisToClient = db.Activities.FirstOrDefault(s => s.ActivityName == activityN);

        //        return returnThisToClient;

        //    }
        //}


        // Below returns just the activity name

        [Route("api/GetWeatherDescription/{activityN}")]
        public string Get(string activityN)
        {


            //Create an instance of the db context

            using (SchoolTourAPIEntities db = new SchoolTourAPIEntities())
            {

                string returnThisToClient = db.Activities.FirstOrDefault(s => s.ActivityName == activityN).WeatherDescription;

                return returnThisToClient;

            }

        }

        [Route("api/GetWeather/{locationN}")]

        public string GetWeatherForLocation(string locationN)
        {
            using (SchoolTourAPIEntities db = new SchoolTourAPIEntities())
            {

                string returnThisToClient = db.Locations.FirstOrDefault(s => s.Location1 == locationN).Weather.WeatherType;


                return returnThisToClient;

            }
        }
    }
}
