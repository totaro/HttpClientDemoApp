
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientDemo.Models
{
    public class PersonModel
    {
        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string LastName { get; set; }

        [BindProperty]
        public string FromTime { get; set; }

        [BindProperty]
        public string ToTime { get; set; }

    }
}
