using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallColliderWithKegel : MonoBehaviour
{
    GameObject bowlingKegel0;
    GameObject bowlingKegel1;
    GameObject bowlingKegel2;
    GameObject bowlingKegel3;
    GameObject bowlingKegel4;
    GameObject bowlingKegel5;
    // Start is called before the first frame update
    void Start()
    {
        bowlingKegel0 = GameObject.FindGameObjectWithTag("Kegel");
        bowlingKegel1 = GameObject.FindGameObjectWithTag("Kegel1");
        bowlingKegel2 = GameObject.FindGameObjectWithTag("Kegel2");
        bowlingKegel3 = GameObject.FindGameObjectWithTag("Kegel3");
        bowlingKegel4 = GameObject.FindGameObjectWithTag("Kegel4");
        bowlingKegel5 = GameObject.FindGameObjectWithTag("Kegel5");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == bowlingKegel0 || collision.gameObject == bowlingKegel1 || collision.gameObject == bowlingKegel2 || collision.gameObject == bowlingKegel3 
            || collision.gameObject == bowlingKegel4 || collision.gameObject == bowlingKegel5)
        {
            transform.GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
