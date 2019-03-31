using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alomero_Housing_Software.BLL
{
    class ClientBLL
    {

        public int ID { get; set; }
        public string DistributionNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IDNumber { get; set; }    
        public string Proffession { get; set; }
        //Contact details
        public string CurrentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string NOKFirstname { get; set; }
        public string NOKLastname { get; set; }
        public string NOKPhoneNumber { get; set; }
        //Stand details 
        public string StandNumber { get; set; }
        public string ResidentialArea { get; set; }
        public string AmountPaidInUS { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public double TotalAmountToBePaid { get; set; }


    }
}
