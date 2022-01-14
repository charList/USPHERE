using System;
using System.Collections.Generic;
using System.Text;

namespace usphere
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int antiquity { get; set; }
        public string Homeland { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
