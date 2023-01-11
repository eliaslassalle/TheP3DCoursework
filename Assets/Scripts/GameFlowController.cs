using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameFlowController : MonoBehaviour
{
    public  int GameState = 0;
    [SerializeField] public  string[] States = new string[12];

    [SerializeField] public  TMP_Text text;



    private void Start()
    {
        UpdateGameState(0);

    }

    public void UpdateGameState(int gamestate)
    {
        GameState = gamestate;
        text.text = States[GameState];
        this.GetComponent<AudioSource>().Play();
    }




}
