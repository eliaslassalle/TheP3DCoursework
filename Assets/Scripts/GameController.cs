using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] private GameObject Sun;

    [SerializeField] private int sunPos1;
    [SerializeField] private int sunPos2;
    [SerializeField] private int sunPos3;
    [SerializeField] private int sunPos4;

    private void Start()
    {

        moveSun(sunPos1);
    }

    public void MakeDay()
    {
    }

    private void moveSun(int place)
    {
        Sun.transform.rotation = Quaternion.Euler(place, Sun.transform.eulerAngles.y, Sun.transform.eulerAngles.z);
    }

    public void SetSleep()
    {
        moveSun(sunPos2);
    }
}
