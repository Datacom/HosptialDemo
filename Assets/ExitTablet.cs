using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTablet : MonoBehaviour, IMixedRealityInputHandler
{
    public GameObject idleTablet;
    public void OnInputDown(InputEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnInputUp(InputEventData eventData)
    {
        if (eventData.GetType().ToString() != "tablet") {
            GameObject.Find("Tablet").SetActive(false);
            idleTablet.SetActive(true);
            //GameObject.Find("TabletOnTable").SetActive(true);
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
