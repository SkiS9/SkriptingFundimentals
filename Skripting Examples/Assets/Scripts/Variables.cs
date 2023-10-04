using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Public Global/Memeber Variables
    public int Score = 0; // declare a whole number
    public float ItemAmount = 19.95f; // decimal
    public string PlayerName = "John Doe"; //Declare a text
    public bool IsPlayerActivw = true; //declare a true/false

    //Private Global/Member Variables
    private int _collectableAmount = 0;
    private float _horizontalInput = 0f;
    private string _userName = "John007";
    private bool _isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // make sure Score Variable is = 0
        Score = 0; // assigning a Global/Member variable

        // declare a local variable to start Position
        Vector3 startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // trying to update a local variables value
        // we can not update a local variable
        //startPosition  = Vector3(Vector3.right)

        // create a variable to determine object key movement
        float verticleInput = Input.GetAxis("Verticle");
    }
}
