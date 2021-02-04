using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransportToReception : MonoBehaviour, IMixedRealityInputHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Scene sceneToLoad = SceneManager.GetSceneByName("Reception");
        //SceneManager.LoadSceneAsync(sceneToLoad.name, LoadSceneMode.Single);
        //SceneManager.MoveGameObjectToScene(GameObject.FindGameObjectWithTag("MixedRealityPlayspace"), sceneToLoad);
    }

    public void OnInputUp(InputEventData eventData)
    {
    }

    public void OnInputDown(InputEventData eventData)
    {
        Scene sceneToLoad = SceneManager.GetSceneByName("Reception");
        SceneManager.LoadSceneAsync(sceneToLoad.name, LoadSceneMode.Single);
        SceneManager.MoveGameObjectToScene(GameObject.FindGameObjectWithTag("MixedRealityPlayspace"), sceneToLoad);
    }
}
