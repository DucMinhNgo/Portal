using System;
using System.Collections.Generic;

namespace FourApplication.Models
{
    public partial class Subjects
    {
        public Subjects()
        {
           
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Created { get; set; }
        public bool IsChecked { get; set; } 

    }
}
