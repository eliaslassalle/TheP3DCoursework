using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedController : MonoBehaviour, Interactable
{

    [SerializeField] private bool isInBed;
    [SerializeField] private GameController gamecontroller;
    [SerializeField] private GameFlowController gameflow;
    [SerializeField] private GameObject torch;

    public void Interact()
    {
        Debug.Log("BED INTERACTED WITH!");
        
        if (!isInBed && gameflow.GameState == 5)
        {
            gameflow.UpdateGameState(6);
            gamecontroller.SetSleep();
            torch.SetActive(false);

        }
        isInBed = true;


    }



}
