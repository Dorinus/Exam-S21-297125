#pragma checksum "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e014bd921a43f302ff92aec12392959f0e5f5fc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using BlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\_Imports.razor"
using BlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreatePlayer")]
    public partial class CreatePlayer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Player</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
               teamName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => teamName = __value, teamName));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 12 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
     if (Teams != null)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
         foreach (var team in Teams)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "option");
            __builder.AddAttribute(5, "value", 
#nullable restore
#line 17 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                            team.TeamName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, 
#nullable restore
#line 17 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                                            team.TeamName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "<text>. </text> ");
            __builder.AddContent(8, 
#nullable restore
#line 17 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                                                                          team.NameOfCoach

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
         
    
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                  NewPlayer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                                             CreateNewPlayer

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, " Name:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "rows", "4");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                                                                         NewPlayer.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewPlayer.Name = __value, NewPlayer.Name))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewPlayer.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, " Position:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "rows", "4");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                                                                             NewPlayer.Position

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewPlayer.Position = __value, NewPlayer.Position))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewPlayer.Position));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, " Salary:<br> ");
                __Blazor.BlazorApplication.Pages.CreatePlayer.TypeInference.CreateInputNumber_0(__builder2, 39, 40, "4", 41, 
#nullable restore
#line 29 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                                                                             NewPlayer.Salary

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewPlayer.Salary = __value, NewPlayer.Salary)), 43, () => NewPlayer.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, " Goals This Season:<br> ");
                __Blazor.BlazorApplication.Pages.CreatePlayer.TypeInference.CreateInputNumber_1(__builder2, 48, 49, "4", 50, 
#nullable restore
#line 30 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
                                                                                        NewPlayer.GoalsThisSeason

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewPlayer.GoalsThisSeason = __value, NewPlayer.GoalsThisSeason)), 52, () => NewPlayer.GoalsThisSeason);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.AddMarkupContent(54, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create Player</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreatePlayer.razor"
       
    IList<Team> Teams = new List<Team>();
    Player NewPlayer = new Player();
    String teamName;


    protected override async Task OnInitializedAsync()
    {
        // sending such arguments to get all teams
        Teams = await TeamManager.GetTeams(-1, null);

    }


    private async void CreateNewPlayer()
    {
        try
        {
            bool response = await PlayerManager.AddPlayer(NewPlayer, teamName);
            if (response)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlayerManager PlayerManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeamManager TeamManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.BlazorApplication.Pages.CreatePlayer
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
