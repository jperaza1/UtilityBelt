﻿using System.Collections.Generic;

namespace UtilityBelt.Models
{
    class SpacePersonModel
    {
        public int number { get; set; }
        public List<SpacePerson> people { get; set; }
        public string message { get; set; }
    }
    public class SpacePerson
    {
        public string craft { get; set; }
        public string name { get; set; }
    }
}
