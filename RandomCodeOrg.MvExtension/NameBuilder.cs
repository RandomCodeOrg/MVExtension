using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomCodeOrg.MvExtension
{
    public class NameBuilder
    {

        public string BuildName(string prefix, string suffix) {
            if (string.IsNullOrEmpty(prefix) && string.IsNullOrEmpty(suffix))
                return "";
            if (string.IsNullOrEmpty(prefix))
                return suffix;
            if (string.IsNullOrEmpty(suffix))
                return prefix;
            if (prefix.EndsWith(".") || suffix.StartsWith(".") || prefix.EndsWith("]") || suffix.StartsWith("["))
                return $"{prefix}{suffix}";
            return $"{prefix}.{suffix}";
        }

    }
}
