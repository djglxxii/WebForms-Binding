using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebForms.Controls
{
    [ParseChildren(false)]
    [PersistChildren(true)]
    public class Tab : WebControl
    {
        public string Title { get;set; }
    }
}