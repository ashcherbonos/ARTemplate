using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARTemplate
{
    public class World : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Main.Store.arOrigin.originIsSet.Bind(s =>gameObject.SetActive(s));
            Main.Store.arOrigin.position.Bind(s => gameObject.transform.position = s);
        }
    }
}