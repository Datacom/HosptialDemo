using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfVideoTransition : MonoBehaviour
{
    private bool hasStartedPlaying = false;
    private bool hasStopped = false;
    public Animator animator;

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
        } else if (!vp.isPlaying && hasStartedPlaying && !hasStopped) {
            animator.SetTrigger("FadeOut");
            SceneManager.LoadSceneAsync("Reception", LoadSceneMode.Single);
            SceneManager.sceneLoaded += OnSceneLoaded;
            hasStopped = true;
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Reception"));
        //animator.ResetTrigger("FadeOut");
        Debug.Log(SceneManager.GetActiveScene().name);
    }
}
