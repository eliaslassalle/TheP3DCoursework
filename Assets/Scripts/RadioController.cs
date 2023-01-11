using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    [SerializeField] GameFlowController gameflow;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "RadioDropZone")
        {
            Debug.Log("brokeRadio");
            gameflow.UpdateGameState(5);
            this.gameObject.SetActive(false);
            
        }
    }
    //bounced our of drop zone before stopping moveing :(
    //&& gameObject.GetComponent<Rigidbody>().velocity.magnitude < 0

}
