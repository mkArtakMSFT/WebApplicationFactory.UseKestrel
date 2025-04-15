using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWeb.Pages;

public class PrivacyModel : PageModel
{
    private readonly IDataService _service;

    public PrivacyModel(IDataService service)
    {
        _service = service;
    }

    public string Data { get => String.Join(',', _service.GetData());}

    public void OnGet()
    {
    }
}

