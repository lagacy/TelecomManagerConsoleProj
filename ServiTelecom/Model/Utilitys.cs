using System;
using System.Collections.Generic;
using System.Text;

namespace ServiTelecom.Utilitys
{
    namespace CredentialUtilitys
    {
        /*Global Enum*/
        public enum Gender
        {
            Male,
            Female,
            NA
        }

        public enum MaritalStatus
        {
            Married,
            Single,
            NA

        }

        public enum StreetType
        {
            ST,
            RUE,
            AVE,
            AV,
            BLVD,
            BOUL,
            NA

        }
        public enum PaymentType
        {
            Credit,
            Debit,
            BankAccount,
            None

        }

        /*ADRESS UTILITYS*/

        //For the moment this is base on Canadian mail system. I will try to use fr and en.
        public class Address
        {
            string unitNumber { get; set; } = "Apartment or Office number"; //ex: Apartment
            string civicNumber { get; set; } = "Civic Number";
            string civicNumberSuffix { get; set; } = "Civic number suffix";
            string streetName { get; set; } = "Street Name";
            string streetType { get; set; } = "String Type";
            string municipalityName { get; set; } = "Name of municipality";
            string province { get; set; } = "Province or territory";
            string postalBoxNumber { get; set; } = "Postal box number";
            string postalCode { get; set; } = "Postal code";
            string RR { get; set; } = "Rural route identifier";//Rural route identifier, ex: "RR 6"
            string StationInfomation { get; set; } = "Station Information";

            //Default constructor - Blank for the moment
            private Address() { }
            //Best to encapsulate the adress making so everything is checked first
            public static Address MakeAddress(int CivicNumber, string StreetName, int UnitNumber, string CivicNumberSuffix,
            string RType, string MunicipalityName, string province, int PostalBox, string PostalCode, int RRNumber, string StationInformation )
            {
                Address tempAdress = new Address();

                return tempAdress;

            }

            //Make an address from a complete string and decompose it.
            public static Address MakeAddress(string CompleteAddress)
            {
                Address tempAddress = new Address();

                return tempAddress;
            }


        }

        /*Personal information utilitys*/
        public struct Credential
        {
            string name;
            string surname;
            Gender gender;
            string birth_Date;
            Address homeAdress;
        }

        /*Billing related utilitys*/
        public struct BillingInfo
        {
            string accountNumber;
            PaymentType paymentType;
            Address billingAddress;

        }
    }
}
