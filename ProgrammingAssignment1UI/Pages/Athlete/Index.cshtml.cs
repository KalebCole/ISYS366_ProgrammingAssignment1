using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgrammingAssignment1UI.Pages.Athlete
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public Models.AthleteInfo CurrentAthlete { get; set; } = new Models.AthleteInfo();
        public void OnGet()
        {
        }
    }
}
