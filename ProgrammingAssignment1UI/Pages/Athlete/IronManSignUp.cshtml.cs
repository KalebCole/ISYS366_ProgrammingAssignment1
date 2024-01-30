using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProgrammingAssignment1UI.Models;

namespace ProgrammingAssignment1UI.Pages.Athlete
{
    public class IronManSignUpModel : PageModel
    {

		private readonly ILogger<IronManSignUpModel> _logger;
		[BindProperty(SupportsGet = true)]
		public AthleteInfo CurrentAthlete { get; set; } = new AthleteInfo();

		public IronManSignUpModel(ILogger<IronManSignUpModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
        {
        }
    }
}
