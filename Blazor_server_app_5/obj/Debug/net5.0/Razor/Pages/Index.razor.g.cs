#pragma checksum "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878f7dc0f1f3438ea75491aace050e17357c5221"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_server_app_5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Blazor_server_app_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Blazor_server_app_5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\Pages\Index.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfComboBox<string, GameFields>>(0);
            __builder.AddAttribute(1, "ID", "ComboBox1");
            __builder.AddAttribute(2, "PopupHeight", "230px");
            __builder.AddAttribute(3, "Placeholder", "Select a game");
            __builder.AddAttribute(4, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<GameFields>>(
#nullable restore
#line 5 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\Pages\Index.razor"
                                                                                                                           Games

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.ComboBoxEvents<string, GameFields>>(6);
                __builder2.AddAttribute(7, "ValueChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, GameFields>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, GameFields>>(this, 
#nullable restore
#line 6 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\Pages\Index.razor"
                                                                    ((e) => OnChange(e, "ComboBox1"))

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.ComboBoxFieldSettings>(9);
                __builder2.AddAttribute(10, "Text", "Text");
                __builder2.AddAttribute(11, "Value", "ID");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfComboBox<string, GameFields>>(13);
            __builder.AddAttribute(14, "ID", "ComboBox2");
            __builder.AddAttribute(15, "PopupHeight", "230px");
            __builder.AddAttribute(16, "Placeholder", "Select a game");
            __builder.AddAttribute(17, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<GameFields>>(
#nullable restore
#line 10 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\Pages\Index.razor"
                                                                                                                           Games

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.ComboBoxEvents<string, GameFields>>(19);
                __builder2.AddAttribute(20, "ValueChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, GameFields>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, GameFields>>(this, 
#nullable restore
#line 11 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\Pages\Index.razor"
                                                                    ((e) => OnChange(e, "ComboBox2"))

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.ComboBoxFieldSettings>(22);
                __builder2.AddAttribute(23, "Text", "Text");
                __builder2.AddAttribute(24, "Value", "ID");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\ManikandanLakshmanan\Downloads\ComboBox_ValueChange\ComboBox_ValueChange\Blazor_server_app_5\Pages\Index.razor"
       
    public class GameFields
    {
        public string ID { get; set; }
        public string Text { get; set; }
    }
    private List<GameFields> Games = new List<GameFields>()
    {
        new GameFields(){ ID= "Game1", Text= "American Football" },
        new GameFields(){ ID= "Game2", Text= "Badminton" },
        new GameFields(){ ID= "Game3", Text= "Basketball" },
        new GameFields(){ ID= "Game4", Text= "Cricket" },
        new GameFields(){ ID= "Game5", Text= "Football" },
        new GameFields(){ ID= "Game6", Text= "Golf" },
        new GameFields(){ ID= "Game7", Text= "Hockey" },
        new GameFields(){ ID= "Game8", Text= "Rugby"},
        new GameFields(){ ID= "Game9", Text= "Snooker" },
        new GameFields(){ ID= "Game10", Text= "Tennis"}
     };

    public void OnChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, GameFields> args, string id)
    {
       
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
