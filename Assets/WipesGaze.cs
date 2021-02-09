using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class WipesGaze : MonoBehaviour, IMixedRealityFocusHandler
{
    public bool isGaze;
    // Is the controller ray focus
    public void OnFocusEnter(FocusEventData eventData)
    {
        isGaze = true;
        print("Is gaze is " + isGaze.ToString());
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        isGaze = false;
        print("Is gaze is updated to " + isGaze.ToString());
    }

    void Awake()
    {
        isGaze = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGaze)
        {
            print("I'm looking at the wipes.");
        }
    }
}
