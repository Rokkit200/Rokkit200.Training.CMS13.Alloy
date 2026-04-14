using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace Alloy.Models.Blocks.Rokkit200_ui.Testimonial
{
    [SiteContentType(
    GUID = "fa945b7e-aa89-4b56-b36e-5c81ed7ad226",
    GroupName = Globals.GroupNames.Content,
    DisplayName = "Testimonial Item Block",
    Description = "A block to display testimonial items.")]
    public class TestimonialItemBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 10,
           Name = "Main Body")]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20,
            Name = "Reviewer Name")]
        public virtual string ReviewerName { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30,
            Name = "Reviewer Job Title")]
        public virtual string ReviewerJobTitle { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40,
            Name = "Reviewer Company")]
        public virtual string ReviewerCompany { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 50,
            Name = "Date")]
        public virtual DateTime Date { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 60,
            Name = "Reviewer Image")]
        [UIHint(UIHint.Image)]
        [IndexingType(IndexingType.Disabled)]
        public virtual ContentReference ReviewerImage { get; set; }
    }
}
