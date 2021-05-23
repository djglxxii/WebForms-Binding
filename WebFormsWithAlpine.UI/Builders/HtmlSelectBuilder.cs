using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebFormsWithAlpine.UI.Controls;

namespace WebFormsWithAlpine.UI.Builders
{
    public class HtmlSelectBuilder : HtmlInputControlBuilder
    {
        public HtmlSelectBuilder(IModelControl control, string propertyName)
            : base(control, propertyName)
        {
            this.BuiltControl = new HtmlSelect();
        }

        public HtmlSelectBuilder WithOptions(params (string, string)[] options)
        {
            foreach (var option in options)
            {
                var li = new ListItem();
                li.Value = option.Item1;
                li.Text = option.Item2;

                ((HtmlSelect)this.BuiltControl).Items.Add(li);
            }
            return this;
        }
    }
}