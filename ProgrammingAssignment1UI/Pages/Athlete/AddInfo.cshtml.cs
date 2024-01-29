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

        [BindProperty(SupportsGet = true)]
        public int NumFromIndex { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? WordFromIndex { get; set; }
        public AddInfoModel(ILogger<AddInfoModel> logger)
		{
			_logger = logger;
		}
		public void OnGet()
		{
            LogInformation("OnGet");

        }

		public IActionResult OnPost()
		{
            LogInformation("OnPost");

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

        private void LogInformation(string methodName)
        {
            _logger.LogInformation($"{methodName} called with Word: {WordFromIndex}, Num: {NumFromIndex}");
        }
    }
}
