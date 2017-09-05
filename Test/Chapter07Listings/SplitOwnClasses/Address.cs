﻿// Copyright (c) 2017 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT licence. See License.txt in the project root for license information.
namespace Test.Chapter07Listings.SplitOwnClasses
{
    public class Address //#C
    {
        public string NumberAndStreet { get; set; }
        public string City { get; set; }
        public string ZipPostCode { get; set; }
        public string CountryCodeIso2 { get; set; }
    }
    /****************************************************
    #C A owned type has no primary key - this type of class is refered to as a 'Value Object' in Domain-Driven Design terms
     * **************************************************/
}