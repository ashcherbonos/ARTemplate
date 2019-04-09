using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace ARTemplate
{
  public class ARPlanesVisualiserManager : MonoBehaviour
  {
    [SerializeField] ARPlaneMeshVisualizer visualiser;

    void Start()
    {
      Main.Store.arOrigin.originIsSet.Bind(s => visualiser.enabled = !s);
    }
  }
}