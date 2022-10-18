using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace mvcDemo.Models
{
    public class Fever
    {
        public string Message { get; set; }
        
        [Required]
        [Display(Name = "Body temprature")]
        public double BodyTemp { get; set; }
       

    }
}
