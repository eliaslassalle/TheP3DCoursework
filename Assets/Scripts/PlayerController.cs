using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int interactReach = 4;
    [SerializeField] Transform rayCastPoint;
    [SerializeField] Transform ItemHeldLocation;
    private GameObject itemHeld;


    public void OnInteract(InputValue value)
    {
        if (value.isPressed)
        {
            if (itemHeld != null)
            {
                itemHeld.GetComponent<Collider>().enabled = true;
                itemHeld.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                itemHeld.gameObject.GetComponent<Rigidbody>().useGravity = true;
                itemHeld.transform.parent = null;
                itemHeld = null;
            }
            else{

                Debug.Log("Interact");
                
                RaycastHit hit;

                if (Physics.Raycast(rayCastPoint.position, rayCastPoint.forward, out hit))
                {
                    Debug.Log(hit.transform.gameObject);
                    if ((hit.distance < interactReach) && (hit.collider.gameObject.tag == "Interactable"))
                    {

                        Debug.Log("Interactable!");

                        hit.collider.gameObject.transform.parent.gameObject.GetComponent<Interactable>().Interact();
                    }

                    if ((hit.distance < interactReach) && ((hit.collider.gameObject.tag == "Item") || hit.collider.gameObject.tag == "Ball"))
                    {
                        
                        itemHeld = hit.collider.gameObject;
                        itemHeld.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        itemHeld.gameObject.GetComponent<Rigidbody>().useGravity = false;
                        itemHeld.transform.position = ItemHeldLocation.position;
                        itemHeld.transform.parent = ItemHeldLocation;
                        itemHeld.GetComponent<Collider>().enabled = false;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
