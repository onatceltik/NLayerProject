﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayerProject.API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }

        //[Required]
        public string Name { get; set; }

        //[Required]
        public int Stock { get; set; }

        //[Required]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
