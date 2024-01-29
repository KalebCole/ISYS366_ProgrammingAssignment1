using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgrammingAssignment1UI.Pages.Athlete
{
	public class IndexModel : PageModel
	{

		[BindProperty(SupportsGet = true)]
		public Models.AthleteInfo CurrentAthlete { get; set; } = new Models.AthleteInfo();

		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
		{
			LogAthleteInfo("Index OnGet");
		}

		public void OnPost()
		{
			LogAthleteInfo("Index OnPost");
		}
		private void LogAthleteInfo(string callingMethod)
		{
			_logger.LogInformation($"{callingMethod} called");
			_logger.LogInformation($"Name: {CurrentAthlete.Name}, Email: {CurrentAthlete.Email}, Phone Number: {CurrentAthlete.PhoneNumber}, Birthday: {CurrentAthlete.Birthday}, Gender: {CurrentAthlete.Gender}");
		}
	}
}
