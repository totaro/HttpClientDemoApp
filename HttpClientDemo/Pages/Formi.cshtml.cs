using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HttpClientDemo.Models;

namespace HttpClientDemo.Pages
{
    //public class Formi
    //{
    //}

    public class IndexModel : PageModel
    {
        public string Name { get; set; }

        public void OnGet()
        {
        }

        public void OnPostSubmit(PersonModel person)
        {
            //this.Name = string.Format("Name: {0} {1}", person.FirstName, person.LastName);
            this.Name = string.Format("Name: {0} {1}", person.FromTime, person.ToTime);
        }
    }





}
