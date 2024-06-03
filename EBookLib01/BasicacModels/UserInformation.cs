﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EBookLib01.BasicacModels
{
   
    public class UserInformation
    {
        [Required]
        public int Id { get; set; }
        public string NickName { get; set; }
        public string ImagePath { get; set; }
        public DateTime BirtDay { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}