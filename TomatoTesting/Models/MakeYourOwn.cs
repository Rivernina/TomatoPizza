﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class MakeYourOwn
    {
        public int MakeYourOwnId { get; set; }
        public string Sauce { get; set; }
        public string Crust { get; set; }
        public ICollection<MakeYourOwnTopping> MakeYourOwnToppings { get; set; }
    }
}
