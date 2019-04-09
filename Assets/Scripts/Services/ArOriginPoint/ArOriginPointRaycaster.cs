using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

namespace ARTemplate.Services.ArOriginPoint
{
  public class ArOriginPointRaycaster : MonoBehaviour
  {
    void Start()
    {
      Main.Store.arOrigin.originIsSet.Bind(s =>
      {
        gameObject.SetActive(!s);
      });
    }

    void Update()
    {
      var ray = Main.Store.mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
      var hitResults = new List<ARRaycastHit>();
      Main.Store.rig.Raycast(ray, hitResults, TrackableType.PlaneWithinBounds);
      if (hitResults.Count == 0) return;
      Main.Store.arOrigin.position.Value = hitResults[0].pose.position;
    }
  }
}