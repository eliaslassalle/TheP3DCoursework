using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private string hibernateTrigger;
    [SerializeField] private string growTrigger;

    private Animator animator;
    private bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("IDie");
        animator.SetBool("Grow", false);
        animator.SetBool("Hibernate", true);
    }

    private void OnTriggerExit(Collider other)
    {

        Debug.Log("IGrow");
        animator.SetBool("Grow", true);
        animator.SetBool("Hibernate", false);
    }
}