using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBowlingBall : MonoBehaviour, IMixedRealityInputHandler
{
    Vector3 initialPosition;
    Vector3 currentPosition;

    public void OnInputDown(InputEventData eventData)
    {
       
    }

    public void OnInputUp(InputEventData eventData)
    {
        transform.GetComponent<Rigidbody>().isKinematic = false;

        currentPosition = transform.position;
        var direction = (currentPosition - initialPosition).normalized;

        transform.GetComponent<Rigidbody>().AddForce(new Vector3(0f, Mathf.Abs(currentPosition.y) * 2f, currentPosition.z - 5f), ForceMode.Impulse);

        initialPosition = currentPosition;
    }

    private void Awake()
    {
        initialPosition = transform.position;
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
