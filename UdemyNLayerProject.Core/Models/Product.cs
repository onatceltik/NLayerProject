﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyNLayerProject.Core.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string InnerBarcode { get; set; }

        // virtual: It will keep track of the changes on the category
        public virtual Category Category { get; set; }
    }
}
