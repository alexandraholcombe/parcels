using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Parcel myParcel = new Parcel();
        myParcel.SetLength(8);
        myParcel.SetWidth(7);
        myParcel.SetHeight(10);
        myParcel.SetWeight(5);
        return View["shipping.cshtml", myParcel];
      };
    }
  }
}
