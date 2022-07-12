using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "پرشدن این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل طول این متن سه کاراکتر")]
        [MaxLength(20)]
        public string name { get; set; }
        [EmailAddress(ErrorMessage = "ادرس ایمیل اشتباه است")]
        public string email { get; set; }
        public string services { get; set; }
        public string message { get; set; }
    }
}
