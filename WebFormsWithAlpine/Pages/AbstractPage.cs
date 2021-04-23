using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Newtonsoft.Json;

namespace WebFormsWithAlpine.Pages
{
    public abstract class AbstractPage<T> : Page where T : new()
    {
        protected T Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //TryUpdateModel()
            }
            else
            {
                Model = GetData();
            }

            DataBind();
        }

        protected virtual T GetData()
        {
            return new T();
        }

        protected virtual string GetJsonData()
        {
            var data = JsonConvert.SerializeObject(Model);

            return data;
        }

        protected override void CreateChildControls()
        {
            // find our root form control and add the Alpine x-data attribute to it.
            MasterPage mp = this.Controls.OfType<MasterPage>().FirstOrDefault();
            HtmlForm form = mp?.Controls.OfType<HtmlForm>().FirstOrDefault();
            if (form != null)
            {
                var json = GetJsonData();
                form.Attributes.Add("x-data", json);
            }

            base.CreateChildControls();
        }
    }
}
