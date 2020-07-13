using System;

namespace BikeDataProject.API.Domain
{
    public class User
    {
        public int Id {get;set;}       

        public string Provider {get;set;} 

        public string AccessToken {get;set;}

        public string RefreshToken {get;set;}

        public DateTime TokenCreationDate {get;set;}
    }
}