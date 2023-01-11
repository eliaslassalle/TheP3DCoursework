using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour, Interactable
{
    [SerializeField] private GameFlowController gameflow;
    [SerializeField] private Transform doorPos;
    [SerializeField] private bool DoorIsOpen = false;
    [SerializeField] private bool DoorMoving = false;
    [SerializeField] private bool doorIsLocked = true;
    [SerializeField] private GameObject LockedDoorUIMessage;
    [SerializeField] GameObject StartBalls;

    private bool startUICounter = false;
    private int uiCounter = 0;
    private int doorCounter = 0;
    private int counter;

    public void Interact(){
        Debug.Log("Door INTERACTED WITH!");

        if (doorIsLocked)
        {
            LockedDoorUIMessage.SetActive(true);
            gameflow.UpdateGameState(2);
            startUICounter = true;
            return;
        }
        if (DoorMoving)
        {
            return;
        }
        else{
            if (DoorIsOpen)
            {
                CloseDoor();
            }
            else
            {
                if(gameflow.GameState == 3)
                {
                    StartBalls.SetActive(true);
                    gameflow.UpdateGameState(4);
                }
                
                OpenDoor();
            }
        }
    }

    public bool GetDoorIsLocked()
    {
        return doorIsLocked;
    }

    public void SetUnlocked()
    {
        doorIsLocked = false;

    }

    private void OpenDoor()
    {
        DoorMoving = true;

    }

    private void CloseDoor()
    {
        DoorMoving = true;

    }

    private void Start()
    {
        

    }

    private void Update()
    {
        


    }

    private void FixedUpdate()
    {

        if(startUICounter)
        {
            counter++;
            if(counter == 200)
            {
                startUICounter = false;
                counter = 0;
                LockedDoorUIMessage.SetActive(false);
            }
        }

        if (DoorMoving == false)
        {
            return;
        }
        else
        {
            if (!DoorIsOpen)
            {
                doorPos.Rotate(0, -1, 0);
                doorCounter++;
                if (doorCounter > 89)
                {
                    DoorMoving = false;
                    DoorIsOpen = true;

                }
            }
            else{
                doorPos.Rotate(0, 1, 0);
                doorCounter--;
                if (doorCounter < 1)
                {
                    DoorMoving = false;
                    DoorIsOpen = false;

                }
            }
        }
    }







}
