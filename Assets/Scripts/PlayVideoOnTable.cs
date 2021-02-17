using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoOnTable : MonoBehaviour, IMixedRealityInputHandler
{
    private GameObject VideoPlayMainScreen;
    private GameObject VideoPlaySplitScreen;
    private bool triggered = false;

    private bool isOnPlaying = false;

    public void OnInputDown(InputEventData eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
        if (!triggered)
        {
            if (isOnPlaying)
            {
                transform.GetComponent<VideoPlayer>().Pause();
                isOnPlaying = true;
            }
            else
            {
                transform.GetComponent<VideoPlayer>().Play();
                isOnPlaying = false;
            }
            triggered = true;
        }
        else
            triggered = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<VideoPlayer>().Play();
        transform.GetComponent<VideoPlayer>().Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
