//using MyProject.Repositories.Entities;
//using System;
//using System.Collections.Generic;
//using MyProject.Repositories.Interfaces;

//namespace MyProject.Mock
//{
//    public class MockContext //: IContex תורידי את ההורשה כי לקונטקסט יש כבר מימוש של הטבלה ממנו שני ותמי האוהבות
//    {
       
//        public List<User> Users { get; set; }
//        public List<Hmo> Hmos { get; set; }
//        public List<Claim> Claims { get; set; }
//        public MockContext()
//        {
//            this.Users = new List<User>();
//            this.Hmos = new List<Hmo>();
//            this.Claims = new List<Claim>();    

//            this.Users.Add(new User { Id = 1, Name = "admin" });
//            this.Users.Add(new User { Id = 2, Name = "user" });

//            this.Hmos.Add(new Hmo { Id = 1, Name = "VIEW_ALL_USERS" });
//            this.Hmos.Add(new Hmo { Id = 2, Name = "ADD_USER" });

//            this.Claims.Add(new Claim { Id = 11,  Policy = ePolicy.Allow });
//            this.Claims.Add(new Claim { Id = 22,  Policy = ePolicy.Deny });
//        }
//    }
//}