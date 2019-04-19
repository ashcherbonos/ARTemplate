using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

namespace ARTemplate.Services
{
  public class ArService : MonoBehaviour
  {
    void Start()
    {
      InitStartMark();

      Main.Store.ar.originIsSet.Bind(s =>
      {
        gameObject.SetActive(!s);
        if (s) Main.Store.ar.session.MakeContentAppearAt(Main.Store.ar.session.transform, Main.Store.ar.position.Value);
      });

      Main.Store.ar.zoom.Bind(s => Main.Store.ar.session.transform.localScale = (1f / s) * Vector3.one);
    }

    void InitStartMark()
    {
      var startmark = Loader.Instantiate<GameObject>(AddressableNames.ARStartMark);
      startmark.GetComponentInChildren<Renderer>().gameObject.AddComponent<ArStartMarkVisibilityDetector>();
      startmark.AddComponent<ArStartMarkPosition>();
    }

    void Update()
    {
      var ray = Main.Store.mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
      var hitResults = new List<ARRaycastHit>();
      Main.Store.ar.session.Raycast(ray, hitResults, TrackableType.PlaneWithinBounds);
      if (hitResults.Count == 0) return;
      Main.Store.ar.position.Value = hitResults[0].pose.position;
    }
  }
}