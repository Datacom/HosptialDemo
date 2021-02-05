using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;

public class EndOfVideoTransition : MonoBehaviour
{
    private bool hasStartedPlaying = false;
    private bool hasStopped = false;
    public Animator animator;

    private IMixedRealityInputSystem inputSystem = null;
    private IMixedRealityInputSystem InputSystem {
        get
        {
            if (inputSystem == null)
            {
                MixedRealityServiceRegistry.TryGetService<IMixedRealityInputSystem>(out inputSystem);
            }
            return inputSystem;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        if (vp.isPlaying){
            hasStartedPlaying = true;
            InputSystem.Disable();
        } else if (!vp.isPlaying && hasStartedPlaying && !hasStopped) {
            animator.SetTrigger("FadeOut");
            hasStopped = true;
            var videoPlayerObj = GameObject.FindGameObjectWithTag("VideoPlayer");
            videoPlayerObj.SetActive(false);
            InputSystem.Enable();
        }
    }
}
