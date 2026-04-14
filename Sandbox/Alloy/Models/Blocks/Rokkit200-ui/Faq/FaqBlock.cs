using System.ComponentModel.DataAnnotations;

namespace Alloy.Models.Blocks.Rokkit200_ui.Faq
{
    [SiteContentType(
    GUID = "a22a47c7-8221-4fb9-a3b5-864ba8ccbcbc",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "FAQ Block",
    Description = "A block to display frequently asked questions and answers.")]
    public class FaqBlock : SiteBlockData
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
            Name = "Items")]
        [AllowedTypes(typeof(FaqItemBlock))]
        public virtual ContentArea Items { get; set; }
    }
}
