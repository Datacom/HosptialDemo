using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlack : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            FadeToBlackFunc();
        }
    }

    public void FadeToBlackFunc(){
        animator.SetTrigger("FadeOut");
    }
}
