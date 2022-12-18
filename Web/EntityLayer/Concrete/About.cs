﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About
    {
        //birincil anahtao hangi sutunun 1. anahta olduğunu gösterir
        [Key]
        public int AboutID { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }
        public string AboutImages1 { get; set; }
        public string AboutImages2 { get; set; }
        public string AboutMapLocation { get; set; }

        public bool AboutStatus { get; set; }
    }
}