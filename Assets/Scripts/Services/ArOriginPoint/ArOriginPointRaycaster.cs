using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARExtensions;

namespace ARTemplate.Services.ArOriginPoint
{
  public class ArOriginPointRaycaster : MonoBehaviour
  {
    void Start()
    {
      Main.Store.arOrigin.originIsSet.Bind(s => gameObject.SetActive(!s));
    }

    void Update()
    {
      var ray = Main.Store.mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
      var hitResults = new List<ARRaycastHit>();
      Main.Store.rig.Raycast(ray, hitResults, TrackableType.PlaneWithinBounds);
      Main.Store.arOrigin.didHit.Value = hitResults.Count > 0;
      if (hitResults.Count == 0) return;
      Main.Store.arOrigin.position.Value = hitResults[0].pose.position;
    }
/*
        void Update()
        {
            RaycastHit hit;
            var ray = Main.Store.mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("hit");
                Main.Store.arOrigin.didHit.Value = true;
                Transform objectHit = hit.transform;
                Main.Store.arOrigin.position.Value = objectHit.position;
            }
            else
            {
                Debug.Log("no");
                Main.Store.arOrigin.didHit.Value = false;
            }
        }

    */
    }
}