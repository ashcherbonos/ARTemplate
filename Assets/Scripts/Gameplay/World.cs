using UnityEngine;

namespace ARTemplate
{
  public class World : MonoBehaviour
  {
    void Start()
    {
      Main.Store.arOrigin.originIsSet.Bind(s =>
      {
          Main.Store.rig.MakeContentAppearAt(transform, Main.Store.arOrigin.position.Value);
          gameObject.SetActive(s);
      });
      //Main.Store.arOrigin.position.Bind(s => gameObject.transform.position = s);
    }
  }
}