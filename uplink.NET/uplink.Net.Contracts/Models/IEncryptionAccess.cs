﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uplink.NET.Contracts.Models
{
    public interface IEncryptionAccess
    {
        string Key { get; set; }
    }
}