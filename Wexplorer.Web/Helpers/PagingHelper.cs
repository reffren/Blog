using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Wexplorer.Web.Models;
using System.Web.Mvc.Html;

namespace Wexplorer.Web.Helpers
{
    public static class PagingHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                    tag.AddCssClass("selected");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }

        //public static MvcHtmlString PageLinksForCategory(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl, int categoryId)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = 1; i <= pagingInfo.TotalPages; i++)
        //    {
        //        TagBuilder tag = new TagBuilder("a");
        //        tag.MergeAttribute("href", pageUrl(i));
        //        tag.InnerHtml = i.ToString();
        //        if (i == pagingInfo.CurrentPage)
        //            tag.AddCssClass("selected");
        //        result.Append(tag.ToString());
        //    }
        //    return MvcHtmlString.Create(result.ToString());
        //}

        public static MvcHtmlString PostLink(this HtmlHelper html, string post_title, string post_file_name, string category_url, string view) // Category needs us just for segment in url
        {
            return html.ActionLink(post_title, view, "Blog", new { cat = category_url, title = post_file_name }, new { title = post_title, @class = "post_preview_a" }); // cat needs us just for segment in url
        }

        public static MvcHtmlString CategoryLink(this HtmlHelper html, string category_name, string category_url, string view)
        {
            return html.ActionLink(category_name, view, "Blog", new { cat = category_url }, new { @class = "post_preview_a" });
        }
    }
}