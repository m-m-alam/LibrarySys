#pragma checksum "F:\pactice\LibrarySys\LibrarySys.Web\Areas\Admin\Views\Shared\_SidebarMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d42a26319a1de12f6bfde845a95e8efd027344e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__SidebarMenu), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SidebarMenu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\pactice\LibrarySys\LibrarySys.Web\Areas\Admin\Views\_ViewImports.cshtml"
using LibrarySys.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\pactice\LibrarySys\LibrarySys.Web\Areas\Admin\Views\_ViewImports.cshtml"
using LibrarySys.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\pactice\LibrarySys\LibrarySys.Web\Areas\Admin\Views\_ViewImports.cshtml"
using LibrarySys.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42a26319a1de12f6bfde845a95e8efd027344e8", @"/Areas/Admin/Views/Shared/_SidebarMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af353239a696bc40013229e5c05879445d26eae", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SidebarMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""sidebar"">
    <!-- Sidebar user panel (optional) -->
    <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
        <div class=""image"">
            <img src=""dist/img/user2-160x160.jpg"" class=""img-circle elevation-2"" alt=""User Image"">
        </div>
        <div class=""info"">
            <a href=""#"" class=""d-block"">Alexander Pierce</a>
        </div>
    </div>

    <!-- Sidebar Menu -->
    <nav class=""mt-2"">
        <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
            <!-- Add icons to the links using the .nav-icon class
         with font-awesome or any other icon font library -->
            <li class=""nav-item"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42a26319a1de12f6bfde845a95e8efd027344e86313", async() => {
                WriteLiteral("\n                    <i class=\"nav-icon fas fa-tachometer-alt\"></i>\n                    <p>\n                        Dashboard                        \n                    </p>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link active"">
                    <i class=""nav-icon fas fa-book""></i>
                    <p>
                        Book
                        <i class=""right fas fa-angle-left""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42a26319a1de12f6bfde845a95e8efd027344e88611", async() => {
                WriteLiteral("\n                            <i class=\"far fa-circle nav-icon\"></i>\n                            <p>Books</p>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </li>\n                    <li class=\"nav-item\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42a26319a1de12f6bfde845a95e8efd027344e810481", async() => {
                WriteLiteral("\n                            <i class=\"far fa-circle nav-icon\"></i>\n                            <p>Add Book</p>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>                   
                </ul>
            </li>
            <li class=""nav-item"">
                <a href=""pages/widgets.html"" class=""nav-link"">
                    <i class=""nav-icon fas fa-th""></i>
                    <p>
                        Widgets
                        <span class=""right badge badge-danger"">New</span>
                    </p>
                </a>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon fas fa-copy""></i>
                    <p>
                        Layout Options
                        <i class=""fas fa-angle-left right""></i>
                        <span class=""badge badge-info right"">6</span>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/layout/top-nav.html"" class=""nav-link"">
                            <i cl");
            WriteLiteral(@"ass=""far fa-circle nav-icon""></i>
                            <p>Top Navigation</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/layout/top-nav-sidebar.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Top Navigation + Sidebar</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/layout/boxed.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Boxed</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/layout/fixed-sidebar.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Fixed Sidebar</p>
                        </a>
                    </l");
            WriteLiteral(@"i>
                    <li class=""nav-item"">
                        <a href=""pages/layout/fixed-topnav.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Fixed Navbar</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/layout/fixed-footer.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Fixed Footer</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/layout/collapsed-sidebar.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Collapsed Sidebar</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-");
            WriteLiteral(@"link"">
                    <i class=""nav-icon fas fa-chart-pie""></i>
                    <p>
                        Charts
                        <i class=""right fas fa-angle-left""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/charts/chartjs.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>ChartJS</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/charts/flot.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Flot</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/charts/inline.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""");
            WriteLiteral(@"></i>
                            <p>Inline</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon fas fa-tree""></i>
                    <p>
                        UI Elements
                        <i class=""fas fa-angle-left right""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/UI/general.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>General</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/UI/icons.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Icons</p>
            ");
            WriteLiteral(@"            </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/UI/buttons.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Buttons</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/UI/sliders.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Sliders</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/UI/modals.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Modals & Alerts</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/UI/navbar.html"" class=""nav-link"">
                ");
            WriteLiteral(@"            <i class=""far fa-circle nav-icon""></i>
                            <p>Navbar & Tabs</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/UI/timeline.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Timeline</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/UI/ribbons.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Ribbons</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon fas fa-edit""></i>
                    <p>
                        Forms
                        <i class=""fas fa-angle-left right""></");
            WriteLiteral(@"i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/forms/general.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>General Elements</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/forms/advanced.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Advanced Elements</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/forms/editors.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Editors</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
               ");
            WriteLiteral(@"         <a href=""pages/forms/validation.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Validation</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon fas fa-table""></i>
                    <p>
                        Tables
                        <i class=""fas fa-angle-left right""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/tables/simple.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Simple Tables</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/tables/data.html"" ");
            WriteLiteral(@"class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>DataTables</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/tables/jsgrid.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>jsGrid</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-header"">EXAMPLES</li>
            <li class=""nav-item"">
                <a href=""pages/calendar.html"" class=""nav-link"">
                    <i class=""nav-icon far fa-calendar-alt""></i>
                    <p>
                        Calendar
                        <span class=""badge badge-info right"">2</span>
                    </p>
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""pages/gallery.html"" class=""nav-link"">
               ");
            WriteLiteral(@"     <i class=""nav-icon far fa-image""></i>
                    <p>
                        Gallery
                    </p>
                </a>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon far fa-envelope""></i>
                    <p>
                        Mailbox
                        <i class=""fas fa-angle-left right""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/mailbox/mailbox.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Inbox</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/mailbox/compose.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                       ");
            WriteLiteral(@"     <p>Compose</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/mailbox/read-mail.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Read</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon fas fa-book""></i>
                    <p>
                        Pages
                        <i class=""fas fa-angle-left right""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/examples/invoice.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Invoice</p>
                        </a>
   ");
            WriteLiteral(@"                 </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/profile.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Profile</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/e-commerce.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>E-commerce</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/projects.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Projects</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/project-add.html"" class=""nav-link"">
      ");
            WriteLiteral(@"                      <i class=""far fa-circle nav-icon""></i>
                            <p>Project Add</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/project-edit.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Project Edit</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/project-detail.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Project Detail</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/contacts.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Contacts</p>
                        </a>
");
            WriteLiteral(@"                    </li>
                </ul>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon far fa-plus-square""></i>
                    <p>
                        Extras
                        <i class=""fas fa-angle-left right""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""pages/examples/login.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Login</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/register.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Register</p>
                        </a>
                    </li>
                  ");
            WriteLiteral(@"  <li class=""nav-item"">
                        <a href=""pages/examples/forgot-password.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Forgot Password</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/recover-password.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Recover Password</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/lockscreen.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Lockscreen</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/legacy-user-menu.html"" class=""nav-link"">
          ");
            WriteLiteral(@"                  <i class=""far fa-circle nav-icon""></i>
                            <p>Legacy User Menu</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/language-menu.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Language Menu</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/404.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Error 404</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/500.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Error 500</p>
                        </a>
                 ");
            WriteLiteral(@"   </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/pace.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Pace</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""pages/examples/blank.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Blank Page</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""starter.html"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Starter Page</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-header"">MISCELLANEOUS</li>
            <li class=""nav-item"">
                <a href=""https://adminlte");
            WriteLiteral(@".io/docs/3.0"" class=""nav-link"">
                    <i class=""nav-icon fas fa-file""></i>
                    <p>Documentation</p>
                </a>
            </li>
            <li class=""nav-header"">MULTI LEVEL EXAMPLE</li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""fas fa-circle nav-icon""></i>
                    <p>Level 1</p>
                </a>
            </li>
            <li class=""nav-item has-treeview"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon fas fa-circle""></i>
                    <p>
                        Level 1
                        <i class=""right fas fa-angle-left""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
                    <li class=""nav-item"">
                        <a href=""#"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Level 2</p>
            ");
            WriteLiteral(@"            </a>
                    </li>
                    <li class=""nav-item has-treeview"">
                        <a href=""#"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>
                                Level 2
                                <i class=""right fas fa-angle-left""></i>
                            </p>
                        </a>
                        <ul class=""nav nav-treeview"">
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link"">
                                    <i class=""far fa-dot-circle nav-icon""></i>
                                    <p>Level 3</p>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link"">
                                    <i class=""far fa-dot-circle nav-icon""></i>
                                    <p>Le");
            WriteLiteral(@"vel 3</p>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link"">
                                    <i class=""far fa-dot-circle nav-icon""></i>
                                    <p>Level 3</p>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#"" class=""nav-link"">
                            <i class=""far fa-circle nav-icon""></i>
                            <p>Level 2</p>
                        </a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""fas fa-circle nav-icon""></i>
                    <p>Level 1</p>
                </a>
            </li>
            <li class=""nav-header"">LABELS</li>
            <");
            WriteLiteral(@"li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon far fa-circle text-danger""></i>
                    <p class=""text"">Important</p>
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon far fa-circle text-warning""></i>
                    <p>Warning</p>
                </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""nav-icon far fa-circle text-info""></i>
                    <p>Informational</p>
                </a>
            </li>
        </ul>
    </nav>
    <!-- /.sidebar-menu -->
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
