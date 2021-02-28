using System.Collections.ObjectModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Controls
{
    [ParseChildren(true, defaultProperty: nameof(Tabs))]
    [PersistChildren(true)]
    public class TabControl : WebControl, INamingContainer
    {
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateInstance(TemplateInstance.Multiple)]
        public Collection<Tab> Tabs { get; set; }

        protected override void RenderChildren(HtmlTextWriter writer)
        {
            foreach (Tab tab in Tabs)
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Li);
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.WriteEncodedText(tab.Title);
                writer.RenderEndTag();
                writer.RenderEndTag();
            }
            
            base.RenderChildren(writer);
        }

        protected override void EnsureChildControls()
        {
            foreach (Tab tab in Tabs)
            {
                Controls.Add(tab);
            }
            
            base.EnsureChildControls();
        }

        protected override void RenderContents(HtmlTextWriter writer)
        {
            //foreach (Tab tab in Tabs)
            //{
            //    tab.RenderControl(writer);
            //}
            
            base.RenderContents(writer);
        }
    }
}