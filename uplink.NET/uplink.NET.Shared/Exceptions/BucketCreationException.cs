﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uplink.NET.Exceptions
{
    public class BucketCreationException : Exception
    {
        public string BucketName { get; set; }
        public BucketCreationException(string bucketName, string error):base(error)
        {
            BucketName = bucketName;
        }
    }
}
