﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseLibrary.Models
{
    public abstract class User
    {
        public string Login { set; get; }
        public string Password { set; get; }
    }
}