﻿using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class tStudent
{
    public string fStuId { get; set; } = null!;

    public string fName { get; set; } = null!;

    public string? fEmail { get; set; }

    public int? fScore { get; set; }
}
