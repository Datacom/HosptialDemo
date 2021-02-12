using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using System.Linq;

public class VideoPlayerMenu : MonoBehaviour, IMixedRealityInputHandler
{
    public VideoClip newVideoClip;
    public VideoClip origVideoClip;
    private bool triggered = false;
    public void OnInputDown(InputEventData eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
        if (!triggered)
        {
            newVideoClip = transform.GetComponent<VideoPlayer>().clip;

            var videoPlayMianScreenVideoPlayer = GameObject.FindGameObjectWithTag("VideoPlayMainScreen").GetComponent<VideoPlayer>();
            origVideoClip = videoPlayMianScreenVideoPlayer.clip;

            videoPlayMianScreenVideoPlayer.clip = newVideoClip;
            videoPlayMianScreenVideoPlayer.Play();
            Debug.Log("Main screen " + videoPlayMianScreenVideoPlayer.clip.name);

            transform.GetComponent<VideoPlayer>().clip = origVideoClip;
            Debug.Log("clicked screen " + transform.GetComponent<VideoPlayer>().clip.name);
            transform.GetComponent<VideoPlayer>().Play();
            transform.GetComponent<VideoPlayer>().Pause();
            triggered = true;
        } else
        {
            triggered = false;
        }
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
