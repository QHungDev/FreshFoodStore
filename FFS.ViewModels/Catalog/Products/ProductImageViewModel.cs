﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FFS.ViewModels.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }

        public string FilePath { get; set; }

        public bool IsDefault { get; set; }

        public long FileSize { get; set; }
    }
}