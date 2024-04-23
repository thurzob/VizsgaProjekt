﻿using System;
using System.Collections.Generic;

namespace Bakcend.Models;

public partial class Aspnetuser
{
    public string Id { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public int Age { get; set; }

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string OrderStatus { get; set; } = null!;

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ICollection<Aspnetuserclaim> Aspnetuserclaims { get; set; } = new List<Aspnetuserclaim>();

    public virtual ICollection<Aspnetuserlogin> Aspnetuserlogins { get; set; } = new List<Aspnetuserlogin>();

    public virtual ICollection<Aspnetusertoken> Aspnetusertokens { get; set; } = new List<Aspnetusertoken>();

    public virtual ICollection<Merchant> Merchants { get; set; } = new List<Merchant>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual ICollection<Aspnetrole> Roles { get; set; } = new List<Aspnetrole>();
}
