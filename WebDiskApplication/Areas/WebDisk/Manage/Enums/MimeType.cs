﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDiskApplication.Areas.WebDisk.Manage.Enums
{
    public enum MimeType : byte
    {
        Document = 11,
        Image = 12,
        Video = 21,
        Audio = 22,
        Zip = 31,
        Unknown = 0
    }
}