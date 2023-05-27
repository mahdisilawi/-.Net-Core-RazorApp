
using System.ComponentModel.DataAnnotations;

namespace Razor_App1.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="وارد کردن عنوان اجباریست")]
        [Display(Name ="عنوان")]
        public string Title { get; set; }

        [Required(ErrorMessage = "وارد کردن تصویر اجباریست")]
        [Display(Name = "تصویر")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "متن جایگزین تصویر اجباریست")]
        [Display(Name = "متن جایگزین تصویر")]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = "عنوان تصویر اجباریست")]
        [Display(Name = "عنوان تصویر")]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = "توضیحات کوتاه اجباریست")]
        [Display(Name = "توضیحات کوتاه")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "متن مقاله اجباریست")]
        [Display(Name = "متن مقاله")]
        public string Body { get; set;}

        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
