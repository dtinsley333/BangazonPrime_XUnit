using System;

namespace BangazonPrimeService
{
    public class User
    {
        public DateTime StartDate{get;set;}
        public DateTime? EndDate{get;set;}
        public int UserId{get;set;}

        public bool IsPrimeUser{get;set;}
        public User(DateTime startDate, DateTime? endDate, int userId)
        {
            this.IsPrimeUser=this.EndDate==null?true:false;
        }
     }
}