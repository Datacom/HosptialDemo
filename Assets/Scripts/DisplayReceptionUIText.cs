using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayReceptionUIText : MonoBehaviour, IMixedRealityInputHandler
{
    public void OnInputDown(InputEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnInputUp(InputEventData eventData)
    {
        //throw new System.NotImplementedException();
        GameObject.Find("ReceptionCanvas").GetComponent<Canvas>().enabled = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(GameObject.Find("ReceptionText").GetComponent<TextMeshProUGUI>().text);
        //GameObject.Find("ReceptionText").GetComponent<TextMeshProUGUI>().text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
