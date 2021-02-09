using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class BathroomDoorScript : MonoBehaviour, IMixedRealityInputHandler
{
    public bool isDoorOpen;
    private float doorOpenRotation_Y = 90f;
    private float doorCloseRotation_Y = -90f;

    [SerializeField]
    private Animator animator;
    public void OnInputDown(InputEventData eventData)
    {
        print("OnInputDown");
    }

    public void OnInputUp(InputEventData eventData)
    {
        //isDoorOpen = !isDoorOpen;
        //if (isDoorOpen)
        //    transform.rotation = new Quaternion(0, doorOpenRotation_Y, 0, 0);
        //else
        //    transform.rotation = new Quaternion(0, doorCloseRotation_Y, 0, 0);

        //transform.RotateAround(transform.position, transform.up, 10 * Time.deltaTime * 90f);
        if (!isDoorOpen)
            transform.GetComponent<AudioSource>().Play();
        animator.SetBool("IsOpening", true);
        isDoorOpen = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        isDoorOpen = false;
        animator = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
