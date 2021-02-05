using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.SceneSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransportToTreatment : MonoBehaviour, IMixedRealityInputHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    print("Controller hit event");
        
    //}

    public void OnInputUp(InputEventData eventData)
    {
    }

    public void OnInputDown(InputEventData eventData)
    {
        MixedRealityToolkit mixedRealityToolkit = new MixedRealityToolkit();

        IMixedRealitySceneSystem sceneSystem = mixedRealityToolkit.GetService<IMixedRealitySceneSystem>();
        sceneSystem.LoadContent("TreatmentRoom").Wait();
        //Scene sceneToLoad = SceneManager.GetSceneByName("TreatmentRoom");
        //SceneManager.LoadSceneAsync("TreatmentRoom", LoadSceneMode.Single);
        //SceneManager.MoveGameObjectToScene(GameObject.FindGameObjectWithTag("MixedRealityPlayspace"), sceneToLoad);
    }
}
