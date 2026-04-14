using System.ComponentModel.DataAnnotations;

namespace Alloy.Models.Blocks.Rokkit200_ui.Faq
{
    [SiteContentType(
    GUID = "c37f55de-a0ba-4d0f-82fc-fd89e4a4ed4e",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "FAQ Item Block",
    Description = "A block for individual frequently asked questions and answers entries.")]
    public class FaqItemBlock : SiteBlockData
    {
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Heading")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20,
            Name = "Main Body")]
        public virtual XhtmlString MainBody { get; set; }
    }
}
