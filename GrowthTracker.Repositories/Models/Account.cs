﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace GrowthTracker.Repositories.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public int RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}