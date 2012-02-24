using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using TrendCustromControls;

namespace TrendWinForm.MyUtilities
{
    class UserContolToValueObject
    {

        public static Address ReturnAddress(AddressUserControl target)
        {
            var address = new Address()
            {
                StreetLine1 = target.StreetLine1,
                StreetLine2 = target.StreetLine2,
                City = target.City,
                ZipCode = target.ZipCode,
                State = target.State
            };
            return address;
        }

        public static PhoneNumber ReturnPhoneNumber(PhoneUserControl target)
        {
            var phoneNum = new PhoneNumber()
                               {
                                  Type = target.Type,
                                  Number = target.Number,
                                  //FirstThreeDigits = target.FirstThreeDigits,
                                  //LastFourDigits = target.LastFourDigits,
                                  AreaCode = target.AreaCode,
                                  Extension = target.Extension
                               };

            return phoneNum;
        }


        public static Name ReturnName   (NameUserControl target)
        {
            var name = new Name()
                           {
                               FirstName = target.FirstName,
                               MiddleNameOrInitial = target.MiddleNameorInitial,
                               LastName = target.LastName
                           };
            return name;
        }

        

    }
}
