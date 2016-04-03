﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatidea.Library.Uploads.Enums
{
    using System.ComponentModel;

    public enum StorageType
    {
        [Description("本地端")]
        Local = 1,

        [Description("Imgur圖床")]
        Imgur = 2,
        Azure = 3,
        S3 = 4
    }
}