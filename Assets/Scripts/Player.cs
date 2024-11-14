using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moneyInMyPocket = 5;


    public string playerName;
    public int playerId;
    public int playerExperience;
    public float playerHealth;

    public bool isWalking;
    public bool isAttacking;
    public bool isRunning;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        print("Jumping");
    }


    void SetupPlayer()
    {
        playerName = "Shen";
        playerId = 1;
        playerExperience = 0;
        playerHealth = 100f;

        isWalking = true;
        isAttacking = false;
    }

    void SayHello()
    {
        print("Hello");
    }

    int AddTwoAndThree()
    {
        print("Adding 2 and 3");
        int result = 2 + 3;
        return result;
    }

    int Add(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }

    bool IsEven(int numberToCheck)
    {
        bool result = (numberToCheck % 2) == 0;
        return result;
    }


    /*
        Arithmetic Operators:
        Addition        +
        Subtraction     -
        Multiplaction   *
        Division        /
        Modulo          %



        Comparison Operators
        
        greater than                >
        greater than or equals      >=
        less than                   <
        less than or equals         <=
        is equal to                 ==
        is not equal to             !=


        Logical Operators
        AND                 &&
        OR                  ||

     */
}
