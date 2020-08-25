﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uccApiCore2.Entities
{
    public class Users
    {
        public int UserID { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public string LoginId { get; set; }
        public string password { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public int UserType { get; set; } = 0;
        public string email { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public int IsApproval { get; set; } = 0;
        public int ApprovedBy { get; set; } = 0;
        public string ApprovedDate { get; set; }
        public string ApprovedByUserName { get; set; }
        public string NewPassword { get; set; }
        public string XMLFilePath { get; set; }
        public string Subject { get; set; }
        public string Token { get; set; }
        public string AdditionalDiscount { get; set; }
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string OrderDetails { get; set; }
        public string DeliveryAddress { get; set; }
        public string Link { get; set; }
        public string LoginURL { get; set; }

    }
}
