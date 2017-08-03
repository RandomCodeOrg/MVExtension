using Microsoft.AspNetCore.Html;
using System;

namespace RandomCodeOrg.MvExtension {
    public static class PartialExtensions {
        
        public static HtmlString PartialFor(this TagHelper) {
            return new HtmlString("");
        }

    }
}
