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
    private GameObject InitialScreenFirst;

    public Vector3 VideoPlayMainScreenPosition;
    public Vector3 VideoPlaySplitScreenObjPosition1;
    public Vector3 VideoPlaySplitScreenObjPosition2;
    public Vector3 VideoPlaySplitScreenObjPosition3;

    public float MoveToX = 0f;
    public float MoveToY = 0.14f;
    public float MoveToZ = 0f;

    private string videoPlaySplitScreenPrefix;
    private bool triggered = false;


    public void OnInputDown(InputEventData eventData)
    {
    }

    public void OnInputUp(InputEventData eventData)
    {
        if (!triggered)
        {
            IsSelected = true;
            SelectedVideoClip = transform.GetComponent<VideoPlayer>().clip;

            if (!VideoPlayMainScreen.GetComponent<Renderer>().enabled)
            {
                VideoPlayMainScreen.GetComponent<Renderer>().enabled = true;
                VideoPlayMainScreen.GetComponent<Transform>().position = new Vector3(VideoPlayMainScreenPosition.x + MoveToX,
                   VideoPlayMainScreenPosition.y + MoveToY, VideoPlayMainScreenPosition.z + MoveToZ);
                //Vector3 change = new Vector3(0.12f, -0.1f, 0f);
                //VideoPlayMainScreen.GetComponent<Transform>().position += change;

                for (int i = 1; i < 4; i++)
                {
                    var videoPlaySplitScreen = videoPlaySplitScreenPrefix + i.ToString();
                    var videoPlaySplitScreenObj = GameObject.FindGameObjectWithTag(videoPlaySplitScreen);
                    if (!videoPlaySplitScreenObj.GetComponent<Renderer>().enabled)
                    {
                        videoPlaySplitScreenObj.GetComponent<Renderer>().enabled = true;
                        if (i == 1)
                            videoPlaySplitScreenObj.GetComponent<Transform>().position = new Vector3(VideoPlaySplitScreenObjPosition1.x + MoveToX,
                                VideoPlaySplitScreenObjPosition1.y + MoveToY, VideoPlaySplitScreenObjPosition1.z + MoveToZ);
                        if (i == 2)
                            videoPlaySplitScreenObj.GetComponent<Transform>().position = new Vector3(VideoPlaySplitScreenObjPosition2.x + MoveToX,
                                VideoPlaySplitScreenObjPosition2.y + MoveToY, VideoPlaySplitScreenObjPosition2.z + MoveToZ);
                        if (i == 3)
                            videoPlaySplitScreenObj.GetComponent<Transform>().position = new Vector3(VideoPlaySplitScreenObjPosition3.x + MoveToX,
                                VideoPlaySplitScreenObjPosition3.y + MoveToY, VideoPlaySplitScreenObjPosition3.z + MoveToZ);
                        //videoPlaySplitScreenObj.GetComponent<Transform>().position += change;

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
        else
        {
            triggered = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        IsSelected = false;

        VideoPlayMainScreen = GameObject.FindGameObjectWithTag("VideoPlayMainScreen");
        InitialScreenFirst = GameObject.FindGameObjectWithTag("InitialSplitScreen1");

        VideoPlayMainScreenPosition = VideoPlayMainScreen.GetComponent<Transform>().position;

        VideoPlayMainScreen.GetComponent<Transform>().position = new Vector3(VideoPlayMainScreen.GetComponent<Transform>().position.x + MoveToX,
            VideoPlayMainScreen.GetComponent<Transform>().position.y + MoveToY, VideoPlayMainScreen.GetComponent<Transform>().position.z + MoveToZ);

        videoPlaySplitScreenPrefix = "VideoPlaySplitScreen";

        for (int i = 1; i < 4; i++)
        {
            var videoPlaySplitScreen = videoPlaySplitScreenPrefix + i.ToString();
            var videoPlaySplitScreenObj = GameObject.FindGameObjectWithTag(videoPlaySplitScreen);
            //if (i == 1)
            //    VideoPlaySplitScreenObjPosition1 = videoPlaySplitScreenObj.GetComponent<Transform>().position;
            //if (i == 2)
            //    VideoPlaySplitScreenObjPosition2 = videoPlaySplitScreenObj.GetComponent<Transform>().position;
            //if (i == 3)
            //    VideoPlaySplitScreenObjPosition3 = videoPlaySplitScreenObj.GetComponent<Transform>().position;
            videoPlaySplitScreenObj.GetComponent<Transform>().position = new Vector3(videoPlaySplitScreenObj.GetComponent<Transform>().position.x + MoveToX,
                videoPlaySplitScreenObj.GetComponent<Transform>().position.y + MoveToY, videoPlaySplitScreenObj.GetComponent<Transform>().position.z + MoveToZ);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
