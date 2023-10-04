using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FunctionsandMethods : MonoBehaviour
{
    public int Score = 0;
    private int _playerHealthAmount = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method examples

    //this method is accesable from other files becuase it is public
    public void UpdatePlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;
    }

    //this method is not accesable from other files
    private void InreseScore()
    {
        Score++; //Score = Score +1
    }

    private void MovePlayer()
    {
        transform.Translate(Vector3.forward);
    }
}
