using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsWithAlpine.UI.Extensions
{
    internal static class PageExtensions
    {
        public static string GetUniquePrefix(this Page page)
        {
            var phs = page.Form.Controls.OfType<ContentPlaceHolder>().ToList();
            if (phs.Count > 1)
            {
                // TODO add support to target a specific ContentPlaceHolder.
                throw new InvalidOperationException(
                    "Pages with multiple ContentPlaceHolder controls is currently not supported.");
            }

            var cph = phs.Single();
            return cph.UniqueID + page.IdSeparator;
        }
    }
}
