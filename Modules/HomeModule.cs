using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/shipping"] = _ => {
        ParcelObject myParcel = new ParcelObject();
        myParcel.SetLength(Request.Query["length"]);
        myParcel.SetWidth(Request.Query["width"]);
        myParcel.SetHeight(Request.Query["height"]);
        myParcel.SetWeight(Request.Query["weight"]);
        return View["shipping.cshtml", myParcel];
      };
    }
  }
}
