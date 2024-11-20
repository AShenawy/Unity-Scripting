using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDCard
{
    public string firstName;
    public string lastName;
    public int age;
    public string idCode;

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }
}


public class IDHandler : MonoBehaviour
{


    IDCard personalID = new IDCard();

    void Start()
    {
        CheckID(personalID);
    }

    private void Update()
    {
        
    }

    void CheckID(IDCard card)
    {
        string fullName = card.GetFullName();
        print("the full name is " +  fullName);

        CompareIDValidity(card.idCode);
    }

    void CompareIDValidity(string id)
    {
        // will check that id
    }
}
