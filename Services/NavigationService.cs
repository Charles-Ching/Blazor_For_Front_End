// NavigationService.cs
using Microsoft.AspNetCore.Components;

namespace EventEase.Services;

public class NavigationService
{
    private readonly NavigationManager _navigationManager;

    public NavigationService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public void NavigateToHomePage()
    {
        _navigationManager.NavigateTo("/");
    }
}
