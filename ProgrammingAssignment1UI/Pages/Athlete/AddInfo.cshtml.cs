using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProgrammingAssignment1UI.Models;

namespace ProgrammingAssignment1UI.Pages.Athlete
{
    public class AddInfoModel : PageModel
    {
		private readonly ILogger<AddInfoModel> _logger;
		[BindProperty(SupportsGet = true)]
		public AthleteInfo CurrentAthlete { get; set; } = new AthleteInfo();
		public AddInfoModel(ILogger<AddInfoModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			_logger.LogInformation("AddInfo OnPost called");
			_logger.LogInformation($"Name: {CurrentAthlete.Name}");
			_logger.LogInformation($"Email: {CurrentAthlete.Email}");
			_logger.LogInformation($"Phone Number : {CurrentAthlete.PhoneNumber}");
			_logger.LogInformation($"Birthday: {CurrentAthlete.Birthday}");
			_logger.LogInformation($"Gender: {CurrentAthlete.Gender}");

			// after this is called
			if (ModelState.IsValid)
			{
				// this class performs a get request to the index page
				return RedirectToPage("./Index", CurrentAthlete);
			}
			else
			{
				return Page();
			}
		}
	}
}
