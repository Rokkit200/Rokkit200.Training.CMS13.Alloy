using System.ComponentModel.DataAnnotations;

namespace Alloy.Models.Blocks.Rokkit200_ui.Testimonial
{
    [SiteContentType(
    GUID = "20036229-3150-4c17-bc58-4e5261d441ea",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "Testimonial Block",
    Description = "A block to display testimonials.")]
    public class TestimonialBlock : SiteBlockData
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
            Name = "Items")]
        [AllowedTypes(typeof(TestimonialItemBlock))]
        public virtual ContentArea Items { get; set; }
    }
}
