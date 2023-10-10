using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Score = 0;
    public string _playerName = "TomBrady";
    public int Health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void IncreaseScore()
    {
        Score += 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log("TomBrady");
    }

    private void DecreaseHealth()
    {
        Health -= 20;
    }
}
