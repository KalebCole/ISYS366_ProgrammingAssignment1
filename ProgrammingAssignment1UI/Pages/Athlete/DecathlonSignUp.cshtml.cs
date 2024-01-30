using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProgrammingAssignment1UI.Models;

namespace ProgrammingAssignment1UI.Pages.Athlete
{
    public class DecathlonSignUpModel : PageModel
    {

		private readonly ILogger<MarathonSignUpModel> _logger;
		[BindProperty(SupportsGet = true)]
		public AthleteInfo CurrentAthlete { get; set; } = new AthleteInfo();
		public void OnGet()
        {
        }

    }
}
