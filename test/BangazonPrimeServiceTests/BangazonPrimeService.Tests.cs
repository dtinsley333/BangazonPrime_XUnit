using System;
using Xunit;
using BangazonPrimeService;


namespace BangazonPrimeService.Tests
{
    public class BangazonPrimeServiceTest
    {
    [Theory,
    InlineData("goodnight moon", "moon", true),
    InlineData("hello world", "hi", false)]
        public void Contains(string input, string sub, bool expected)
        {
            var actual = input.Contains(sub);
            Assert.Equal(expected, actual);
        }

        [Fact]
         public void UserHasBangazonPrime()
        {
            User bangazonUser=new User(DateTime.Now.AddMonths(-1),null, 123);//no end date means they have amazon prime
            bool actual=bangazonUser.IsPrimeUser;
            Assert.Equal(true, actual); 
        }

        [Fact]
        public void UserIsNotBangazonPrimeUser()
        {
            User bangazonUser=new User(DateTime.Now.AddMonths(-11),DateTime.Now.AddMonths(-1), 344); //End Date in the past means no amazon prime
            bool actual=bangazonUser.IsPrimeUser;
            Assert.Equal(false, actual);
        }

 
        [Theory,InlineData(123, true), 
               InlineData(246, false)]
            public void ProductIsBangazonPrimeEligible(int product, bool expected)
        {
                Product bangazonProduct=new Product(productId);
                bool actual=bangazonProduct.IsPrimeProduct;
                Assert.Equal(true, actual); 
        }

         [Fact]
            public void RemoveShippingCostsWhenProductIsPrime()
        {
                double cost=12.00;
                double shipping=1.50;
                Product bangazonProduct=new Product(123, cost, shopping); 
                double finalcost=bangazonProduct.FinalCost;
                Assert.Equal(bangazonProduct.Cost,finalcost);
        }
       
        [Fact]
        public void KeepShippingCostsWhenProductIsNotPrime()
        {
                double cost=12.00;
                double shipping=1.50;
                Product bangazonProduct=new Product(456, cost, shopping); 
                double finalcost=bangazonProduct.FinalCost;
                Assert.Equal(bangazonProduct.Cost + shipping,finalcost);
        }

        [Fact]   
        public void HolidayMovieStreamingOfferAvailable()
         {
                //user must have bangazon prime
                //current month must be be in the range of October to January
                //Product must be of type "Movie"
                User bangazonUser=new User(DateTime.Now.AddMonths(-1),null, 123);
                Product bangazonProduct=new Product(222);
                bool actual=bangazonProduct.IsEligibleForStreaming && bangazonUser.IsPrimeUser;
                Assert.Equal(true, actual); 
        }

            //Create a test to make sure movies that are not eligible for streaming are indeed not eligible. 

    }
}