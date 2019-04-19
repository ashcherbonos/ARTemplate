using UnityEngine;
using ARTemplate.Services;

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
    private ArService arService;

    public Servicer()
    {
      var go = new GameObject("Services");
      arService = go.AddComponent<ArService>();
    }

    public void Start()
    {

    }
  }
}
