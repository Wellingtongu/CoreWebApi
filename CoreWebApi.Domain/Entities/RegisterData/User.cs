using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApi.Domain.Entities.RegisterData
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Admision { get; set; }
    }
}
