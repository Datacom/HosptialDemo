using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideNurseCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
