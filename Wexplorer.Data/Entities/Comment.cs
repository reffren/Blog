using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wexplorer.Data.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Пожалуйста укажите Ваше имя")]
        public string NameUser { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Пожалуйста укажите Ваш E-mail")]
        public string Email { get; set; }

        [Display(Name = "Сайт")]
        public string Site { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Пожалуйста введите текст комментария")]
        public string Commentary { get; set; }
        public DateTime PublishedDate { get; set; }
        public int PostID { get; set; }
        public virtual Post Post { get; set; }
    }
}