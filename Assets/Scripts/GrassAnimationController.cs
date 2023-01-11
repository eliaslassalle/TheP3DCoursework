using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassAnimationController : MonoBehaviour
{

    [SerializeField] private Animator animator;
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("Hibernate", true);
            animator.SetBool("Grow", false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Grow", true);
            animator.SetBool("Hibernate", false);
        }
    }
}
