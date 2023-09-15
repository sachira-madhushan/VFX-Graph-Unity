using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
public class Player : MonoBehaviour
{
    private Animator animator;
    public VisualEffect vfx;
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("PowerUp");
            vfx.Play();
        } 
    }

   
}
