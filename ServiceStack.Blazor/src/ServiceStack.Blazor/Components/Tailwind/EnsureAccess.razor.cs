﻿using Microsoft.AspNetCore.Components;

namespace ServiceStack.Blazor.Components.Tailwind;

public partial class EnsureAccess : AuthBlazorComponentBase
{
    [Inject] NavigationManager NavigationManager { get; set; }
    [Parameter, EditorRequired] public string HtmlMessage { get; set; } = "";
    [Parameter] public EventCallback Done { get; set; }
    [Parameter] public string? Title { get; set; }
    [Parameter] public string? SubHeading { get; set; }

    async Task signIn()
    {
        NavigationManager.NavigateTo(NavigationManager.GetLoginUrl());
    }
}