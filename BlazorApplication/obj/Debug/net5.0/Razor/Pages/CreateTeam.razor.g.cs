#pragma checksum "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c74dfce70143f35edaa33ce468138883e5340fc9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateTeam")]
    public partial class CreateTeam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateTeam</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor"
                  newTeam

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor"
                                           CreateNewTeam

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, " Team Name:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "rows", "4");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor"
                                                                              newTeam.TeamName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTeam.TeamName = __value, newTeam.TeamName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTeam.TeamName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, " Name Of Coach:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "rows", "4");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor"
                                                                                  newTeam.NameOfCoach

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTeam.NameOfCoach = __value, newTeam.NameOfCoach))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTeam.NameOfCoach));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, " Ranking:<br> ");
                __Blazor.BlazorApplication.Pages.CreateTeam.TypeInference.CreateInputNumber_0(__builder2, 30, 31, "4", 32, 
#nullable restore
#line 14 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor"
                                                                              newTeam.Ranking

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTeam.Ranking = __value, newTeam.Ranking)), 34, () => newTeam.Ranking);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.AddMarkupContent(36, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create Team</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\dotNetProjects\Exam-S21-297125\BlazorApplication\Pages\CreateTeam.razor"
       
    private Team newTeam = new Team();

    private async void CreateNewTeam()
    {
        try
        {
            var response = await TeamManager.CreateTeam(newTeam);
            if (response)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeamManager TeamManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.BlazorApplication.Pages.CreateTeam
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
    }
}
#pragma warning restore 1591
