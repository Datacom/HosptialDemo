using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransportToTreatment : MonoBehaviour
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
        print("Controller hit event");
        if (hit.gameObject.tag == "Player")
        {
            Scene sceneToLoad = SceneManager.GetSceneByName("TreatmentRoom");
            SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
            SceneManager.MoveGameObjectToScene(hit.gameObject, sceneToLoad);
        }
    }
}
