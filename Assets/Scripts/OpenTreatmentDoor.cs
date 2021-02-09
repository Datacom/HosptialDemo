using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class OpenTreatmentDoor : MonoBehaviour, IMixedRealityInputHandler
{
    bool isDoorOpen;
    [SerializeField]
    private Animator animator;
    public void OnInputDown(InputEventData eventData)
    {
    }

    public void OnInputUp(InputEventData eventData)
    {
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
