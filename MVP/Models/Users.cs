﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Models
{
  public class Users
  {
    [Key]
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
}
