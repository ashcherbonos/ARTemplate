using UnityEngine;
using ARTemplate.Services;
using ARTemplate.Services.ArOriginPoint;

namespace ARTemplate
{
  /// <summary>
  /// Dataless business logic implemented in independend services.
  /// (For data storing, use Main.Store)
  /// Service workflow:
  /// Store.Bind => Logic => Store.SetValue
  /// </summary>
  public class Servicer
  {
    private ArOriginPointRaycaster arOriginPointRaycaster;
    //private ArStartMark arStartMark;
    public Servicer()
    {
      var go = new GameObject("Services");
      arOriginPointRaycaster = go.AddComponent<ArOriginPointRaycaster>();
      ///arStartMark = go.AddComponent<ArStartMark>();
    }

    public void Start()
    {

    }
  }
}
