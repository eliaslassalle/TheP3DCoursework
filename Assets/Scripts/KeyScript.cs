using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private GameFlowController gameflow;
    [SerializeField] private GameObject doorController;

    private void OnTriggerEnter(Collider other)
    {
        doorController.GetComponent<DoorController>().SetUnlocked();
        gameflow.UpdateGameState(3);
        this.gameObject.SetActive(false);
    }


}
