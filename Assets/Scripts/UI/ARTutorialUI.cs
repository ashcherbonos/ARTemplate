using UnityEngine;

namespace ARTemplate.UI
{
    public class ARTutorialUI : MonoBehaviour
    {
        [SerializeField] GameObject lookAraund;
        [SerializeField] GameObject tapToStart;
        [SerializeField] GameObject resetOriginPoint;

        void Start()
        {
            Main.Store.arOrigin.originIsSet.Bind(s =>
            {
                resetOriginPoint.SetActive(s);
                lookAraund.SetActive(!s);
            });
            Main.Store.arOrigin.markIsVisible.Bind(s =>
            {
                lookAraund.SetActive(!s);
                tapToStart.SetActive(s);
            });
        }

        public void OnTapToStartClick()
        {
            Main.Store.arOrigin.originIsSet.Value = true;
        }

        public void OnResetClick()
        {
            Main.Store.arOrigin.originIsSet.Value = false;
        }
    }
}
