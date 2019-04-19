using UnityEngine;
using UnityEngine.UI;

namespace ARTemplate.UI
{
  public class ARTutorialUI : MonoBehaviour
  {
    [SerializeField] GameObject lookAraund;
    [SerializeField] GameObject tapToStart;
    [SerializeField] GameObject resetOriginPoint;
    [SerializeField] Slider zoomSlider;

    void Start()
    {
      zoomSlider.minValue = Constants.MinArZoom;
      zoomSlider.maxValue = Constants.MaxArZoom;
      zoomSlider.value = Constants.DefaultArZoom;

      Main.Store.ar.originIsSet.Bind(_ => SetVisibility());
      Main.Store.ar.markIsVisible.Bind(_ => SetVisibility());
    }

    void SetVisibility()
    {
      var originIsSet = Main.Store.ar.originIsSet.Value;
      var markIsVisible = Main.Store.ar.markIsVisible.Value;

      lookAraund.SetActive(!originIsSet && !markIsVisible);
      tapToStart.SetActive(!originIsSet && markIsVisible);
      resetOriginPoint.SetActive(originIsSet);
    }

    public void OnTapToStartClick()
    {
      Main.Store.ar.originIsSet.Value = true;
    }

    public void OnResetClick()
    {
      Main.Store.ar.originIsSet.Value = false;
    }

    public void OnZoomSliderValueChange()
    {
      Main.Store.ar.zoom.Value = zoomSlider.value;
    }
  }
}
