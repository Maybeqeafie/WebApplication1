using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Input
    {
        public string Text { get; set; }

        public IEnumerable<string> Values { get; set; }

        public IEnumerable<string> Values1 { get; set; }

        public string Option { get; set; }

    }
}