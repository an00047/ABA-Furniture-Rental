﻿using System;


namespace AAB_Furniture_Rentals.Model
{
    /// <summary>
    /// Object model class for a store member
    /// </summary>
    public class Member
    {
        /// <summary>
        /// the key for the meber in the DB
        /// </summary>
        public int MemberID { get; set; }
        /// <summary>
        /// members first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// members last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// the members gender
        /// </summary>
        public char Gender { get; set; }
        /// <summary>
        /// the members DOB
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// the members address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// the members phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// the members city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// the members state
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// the members zip
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// constructor method for the member object model
        /// </summary>
        /// <param name="memberID"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="sex"></param>
        /// <param name="dob"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        public Member(
            int memberID,
            string fname,
            string lname,
            char sex,
            DateTime dob,
            string address,
            string phone,
            string city,
            int state,
            string zip
            )
        {
            this.MemberID = memberID;
            this.Address = address;
            this.FirstName = fname;
            this.LastName = lname;
            this.DateOfBirth = dob.Date;
            this.PhoneNumber = phone;
            this.Gender = sex;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        /// <summary>
        /// empty constructor for null initialization, wehn desired
        /// </summary>
        public Member() { }
    }

}
