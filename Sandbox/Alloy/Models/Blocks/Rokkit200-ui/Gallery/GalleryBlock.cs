using System.ComponentModel.DataAnnotations;

namespace Alloy.Models.Blocks.Rokkit200_ui.Gallery
{
    [SiteContentType(
    GUID = "d78d56a2-74ed-4e73-822a-5da1dff43eca",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "Gallery Block",
    Description = "A block to display a collection of gallery items.")]
    public class GalleryBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Items")]
        [AllowedTypes(typeof(GalleryItemBlock))]
        public virtual ContentArea Items { get; set; }
    }
}
