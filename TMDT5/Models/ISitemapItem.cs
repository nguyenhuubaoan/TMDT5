﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDT5.Models
{
    public interface ISitemapItem
    {
        string Url { get; }
        DateTime? LastModified { get; }
        SitemapChangeFrequency? ChangeFrequency { get; }
        double? Priority { get; }
    }
}
