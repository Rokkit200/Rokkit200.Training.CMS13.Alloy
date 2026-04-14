using System.ComponentModel.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace Alloy.Models.Blocks.Rokkit200_ui.Hero
{
    [SiteContentType(
    GUID = "9750cbb3-f394-4cbc-9700-f3349f52172e",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "Hero Block",
    Description = "A block to display a hero section with heading, body, links, and media.")]
    public class HeroBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Heading")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20,
            Name = "Main Body")]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30,
            Name = "Links")]
        public virtual LinkItemCollection Links { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40,
            Name = "Media")]
        [UIHint(UIHint.Image)]
        [IndexingType(IndexingType.Disabled)]
        public virtual ContentReference Media { get; set; }
    }
}
