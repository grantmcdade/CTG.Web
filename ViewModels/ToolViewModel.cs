using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CTG.Core.ViewModels
{
    public class ToolViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Controller { get; set; }
        public string Action { get; set; }
        public string Permission { get; set; }

        [Display(Name = "Pre Image Description")]
        [DataType(DataType.MultilineText)]
        public string PreImageDescription { get; set; }

        public string Description { get; set; }

        [DisplayName("Detailed Description")]
        [DataType(DataType.MultilineText)]
        public string DetailDescription { get; set; }

        [DisplayName("Video Source")]
        public string VideoSrc { get; set; }

        [DisplayName("Image Source")]
        [DataType(DataType.ImageUrl)]
        public string ImageSrc { get; set; }

        [DisplayName("Detailed Image Source")]
        [DataType(DataType.ImageUrl)]
        public string DetailImageSrc { get; set; }
    }
}
