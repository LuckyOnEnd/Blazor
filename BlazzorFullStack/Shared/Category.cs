using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazzorFullStack.Shared
{
    public class Category
    {
        public int Id { get; set; }
        public string CarType { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
