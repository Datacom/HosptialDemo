using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class OpenTreatmentDoor : MonoBehaviour, IMixedRealityInputHandler
{
    [SerializeField]
    private Animator animator;
    public void OnInputDown(InputEventData eventData)
    {
    }

    public void OnInputUp(InputEventData eventData)
    {
        animator.SetBool("IsOpening", true);
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
