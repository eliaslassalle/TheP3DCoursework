using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{
    [SerializeField] private GameObject torchLight;
    [SerializeField] private GameFlowController gameflow;

    private void Start()
    {
        torchLight.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        torchLight.SetActive(true);
        gameflow.UpdateGameState(1);
        this.gameObject.SetActive(false);



    }


}
