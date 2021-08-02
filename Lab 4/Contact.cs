/* 
 * Author: Siddharth Choudhury
 * Date: July 13, 2021
 * Title: Lab 4 for NETD2202
 * Sub-Title:  Lab 4 Class Definition
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Contact
    {
        #region PROPERTIES


        public int Count { get; set; }
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Date { get; set; }
        public String EmailAddress { get; set; }
        public Boolean ContactStatus { get; set; }
        public String PhoneNumber { get; set; }

        #endregion


        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor - SID WAS HERE
        /// </summary>
        public Contact() 
        {
            Count ++;
            Id = Count;
        }

        /// <summary>
        /// Parameterized Constructor - CID WAS ALSO HERE
        /// </summary>
        /// <param name="firstName">First name of the person </param>
        /// <param name="lastName">Last name of the person</param>
        /// <param name="emailAddress">Email address of the person </param>
        /// <param name="phoneNumber"> Phone number of the person</param>
        /// <param name="contactStatus">Whethere or not they have been contacted</param>
        public Contact(String firstName, String lastName, String emailAddress, String phoneNumber, Boolean contactStatus)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            ContactStatus = contactStatus;
        }


        #endregion


        #region FUNCTION

        private void GetStatus(String firstName, String lastName, String emailAddress, DateTime dateTime, Boolean contactStatus)
        {

        }

        #endregion
    }
}
