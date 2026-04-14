using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace Alloy.Models.Blocks.Rokkit200_ui.LogoCloud
{
    [SiteContentType(
    GUID = "7c3c22ea-5606-437c-bee1-875ec461b6f0",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "Logo Cloud Block",
    Description = "A block to display logos.")]
    public class LogoCloudBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Items")]
        [UIHint(UIHint.Image)]
        [IndexingType(IndexingType.Disabled)]
        public virtual IList<ContentReference> Items { get; set; }
    }
}
