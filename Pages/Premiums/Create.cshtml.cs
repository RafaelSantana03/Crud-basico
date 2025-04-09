using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BaltaTest.Data;
using BaltaTest.Models;

namespace BaltaTest.Pages_Premiums;

public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public CreateModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Premium Premium { get; set; } = default!;

    public SelectList StudentsSelectList { get; set; } = default!;

    public IActionResult OnGet()
    {
        StudentsSelectList = new SelectList(_context.Students, "Id", "Email");
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid || _context.Premiums == null || Premium == null)
        {
            StudentsSelectList = new SelectList(_context.Students, "Id", "Email");
            return Page();
        }

        _context.Premiums.Add(Premium);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
