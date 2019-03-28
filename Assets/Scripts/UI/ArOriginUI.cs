using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARTemplate.UI
{
  public class ArOriginUI : MonoBehaviour
  {
    void Start()
    {
      Main.Store.arOrigin.originIsSet.Bind(_ => SetVisibility());
      //Main.Store.arOrigin.didHit.Bind(_ => SetVisibility());
      Main.Store.arOrigin.markIsVisible.Bind(_ => SetVisibility());
    }

    private void SetVisibility()
    {
      var originIsSet = Main.Store.arOrigin.originIsSet.Value;
      //var didHit = Main.Store.arOrigin.didHit.Value;
      var markIsVisible = Main.Store.arOrigin.markIsVisible.Value;
      gameObject.SetActive(!originIsSet && !markIsVisible);
    }
  }
}
