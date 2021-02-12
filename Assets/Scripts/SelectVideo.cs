using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SelectVideo : MonoBehaviour, IMixedRealityInputHandler
{

    public VideoClip SelectedVideoClip;
    public bool IsSelected;
    private GameObject VideoPlayMainScreen;
    private GameObject VideoPlaySplitScreen;

    void Awake()
    {
        
    }
    public void OnInputDown(InputEventData eventData)
    {
    }

    public void OnInputUp(InputEventData eventData)
    {
        Debug.Log(transform.name);

        IsSelected = true;
        SelectedVideoClip = transform.GetComponent<VideoPlayer>().clip;

        var videoPlaySplitScreenPrefix = "VideoPlaySplitScreen";

        VideoPlayMainScreen = GameObject.FindGameObjectWithTag("VideoPlayMainScreen");

        if (!VideoPlayMainScreen.GetComponent<Renderer>().enabled)
        {
            VideoPlayMainScreen.GetComponent<Renderer>().enabled = true;
           // VideoPlayMainScreen.GetComponent<Transform>().position = new Vector3(VideoPlayMainScreen.GetComponent<Transform>().position.x,
               //VideoPlayMainScreen.GetComponent<Transform>().position.y, 0.05f);
            Vector3 change = new Vector3(0, 0, 0.014f);
            VideoPlayMainScreen.GetComponent<Transform>().position += change;

            for (int i = 1; i < 4; i++)
            {
                var videoPlaySplitScreen = videoPlaySplitScreenPrefix + i.ToString();
                var videoPlaySplitScreenObj = GameObject.FindGameObjectWithTag(videoPlaySplitScreen);
                if (!videoPlaySplitScreenObj.GetComponent<Renderer>().enabled)
                {
                    videoPlaySplitScreenObj.GetComponent<Renderer>().enabled = true;
                    //videoPlaySplitScreenObj.GetComponent<Transform>().position = new Vector3(videoPlaySplitScreenObj.GetComponent<Transform>().position.x,
                //videoPlaySplitScreenObj.GetComponent<Transform>().position.y, 0.05f);
                    videoPlaySplitScreenObj.GetComponent<Transform>().position += change;

                }
            }
        }

        // Disable initial split screens
        var initialSplitScreenPrefix = "InitialSplitScreen";
        for (int i = 1; i < 5; i++)
        {
            var initialSplitScreen = initialSplitScreenPrefix + i.ToString();

            var initialSplitScreenObject = GameObject.FindGameObjectWithTag(initialSplitScreen);
            if (initialSplitScreenObject.GetComponent<Renderer>().enabled)
                initialSplitScreenObject.GetComponent<Renderer>().enabled = false;
        }

        ////Assign unselected video clips to the video play split screens
        var VideoPlaySplitScreenPrefix = "VideoPlaySplitScreen";
        int j = 1;
        // VideoPlayMainScreen
        for (int i = 1; i < 5; i++)
        {
            var InitialSplitScreen = initialSplitScreenPrefix + i.ToString();
            var InitialSplitScreenObject = GameObject.FindGameObjectWithTag(InitialSplitScreen);
            if (!InitialSplitScreenObject.GetComponent<SelectVideo>().IsSelected && j < 4)
            {
                VideoClip unselected = InitialSplitScreenObject.GetComponent<VideoPlayer>().clip;
                GameObject.FindGameObjectWithTag(VideoPlaySplitScreenPrefix + j.ToString()).GetComponent<VideoPlayer>().clip = unselected;
                GameObject.FindGameObjectWithTag(VideoPlaySplitScreenPrefix + j.ToString()).GetComponent<VideoPlayer>().Play();
                GameObject.FindGameObjectWithTag(VideoPlaySplitScreenPrefix + j.ToString()).GetComponent<VideoPlayer>().Pause();
                j++;
            }
        }

        //Assign selected video clip to the video play main screen
        var videoPlayMainScreen = GameObject.FindGameObjectWithTag("VideoPlayMainScreen");
        var videoPlayMainScreenVideoPlayer = videoPlayMainScreen.GetComponent<VideoPlayer>();
        videoPlayMainScreenVideoPlayer.clip = transform.GetComponent<VideoPlayer>().clip;
        videoPlayMainScreenVideoPlayer.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        IsSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
