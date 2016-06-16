using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;

namespace clean_architecture_in_asp_net_core_mvc.Lib
{
    public class CustomViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values["customviewlocation"] = nameof(CustomViewLocationExpander);
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var viewLocationFormats = new[]
            {
                "~/{1}/{0}.cshtml",
                "~/Shared/{0}.cshtml"
            };
            return viewLocationFormats;
        }
    }
}
