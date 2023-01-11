using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private string otherTag;

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("made it here!");
        if (other.gameObject.tag == otherTag)
        {
            Destroy(other.gameObject);
        }
    }
}