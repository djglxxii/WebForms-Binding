using System.Collections.ObjectModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Controls
{
    [ParseChildren(true, defaultProperty: nameof(ValidatedControls))]
    public class Validatable : Control
    {
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public Collection<WebControl> ValidatedControls { get; set; }

        protected override void CreateChildControls()
        {
            Controls.Clear();      // clear out the control hierarchy
            //ValidatedControl.InstantiateIn(this);


            //// create a new StatsData instance based on the property values
            //this.statsData = new StatsData(this.Title, this.TotalPostCount,
            //    this.TotalUserCount);

            //// instantiate the StatsData in the template
            //StatsTemplate.InstantiateIn(statsData);

            //Controls.Add(statsData);      // add the StatsData to the control 
            //hierarchy
        }

        public override void DataBind()
        {
            CreateChildControls();
            this.ChildControlsCreated = true;

            base.DataBind();
        }
    }
}