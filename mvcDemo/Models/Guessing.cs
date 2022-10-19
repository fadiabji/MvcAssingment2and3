using System.ComponentModel.DataAnnotations;

namespace mvcDemo.Models
{
    public class Guessing
    {
        [Display(Name = "Secret Number")]
        [Required]
        public int SNumber { get; set; }
        public int  Guess { get; set; }

        public string Message { get; set; }

        public int Index { get; set; } = 0;

        public void IncreaseIndex()
        {
            Index++; 
        }
    }
}
