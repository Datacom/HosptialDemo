using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour, IMixedRealityFocusHandler
{
    public VideoPlayer myVideoPlayer;
    public bool isPlay;
    public void OnFocusEnter(FocusEventData eventData)
    {
        myVideoPlayer.Play();
        isPlay = true;
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        if (isPlay)
        {
            myVideoPlayer.Pause();
            isPlay = false;
        }
    }

    private void Awake()
    {
        myVideoPlayer = transform.GetComponent<VideoPlayer>();
        isPlay = false;
        myVideoPlayer.Stop();
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
