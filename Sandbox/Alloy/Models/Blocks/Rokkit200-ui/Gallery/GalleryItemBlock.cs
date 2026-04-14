using System.ComponentModel.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace Alloy.Models.Blocks.Rokkit200_ui.Gallery
{
    [SiteContentType(
    GUID = "8381814d-dcf2-4cb3-9121-a2da5327893f",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "Gallery Item Block",
    Description = "A block to display gallery items.")]
    public class GalleryItemBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Media")]
        [UIHint(UIHint.Image)]
        [IndexingType(IndexingType.Disabled)]
        public virtual ContentReference Media { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20,
            Name = "Pre-Heading")]
        [MaxLength(255)]
        public virtual string PreHeading { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30,
            Name = "Heading")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 40,
           Name = "Main Body")]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 50,
            Name = "Links")]
        public virtual LinkItemCollection Links { get; set; }
    }
}
