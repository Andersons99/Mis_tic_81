#pragma checksum "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760d8052d7a2cee139dca31934a7015cbed0d125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Usuario.Pages_Usuario_Details), @"mvc.1.0.razor-page", @"/Pages/Usuario/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Usuario
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
#line 1 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760d8052d7a2cee139dca31934a7015cbed0d125", @"/Pages/Usuario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e951d19b2ecc2bc4f6f9fb2cd923147b6311c168", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Usuario_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
  
    var usuario = Model.Usuario;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n<ul class=\"list-group list-group-flush\">\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                      Write(usuario.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"> <b>Nombre: </b> ");
#nullable restore
#line 9 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                          Write(usuario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"> <b>Apellidos: </b> ");
#nullable restore
#line 10 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                             Write(usuario.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"><b>Direccion: </b> ");
#nullable restore
#line 11 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                            Write(usuario.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"><b>Telefono: </b> ");
#nullable restore
#line 12 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                           Write(usuario.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"><b>Ciudad: </b> ");
#nullable restore
#line 13 "C:\Users\Anderson Sachez\Desktop\Proyecto81Ciclo3\ProyectoCiclo3.App.Frontend\Pages\Usuario\Details.cshtml"
                                         Write(usuario.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>  ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsUsuarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
