using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    IDCard card1;
    IDCard card2;
    IDCard card3;
    IDCard card4;

    public string[] names = { "Shen", "Semjon", "Elinda", "Jason" };
    IDCard[] iDCards = { new IDCard(), new IDCard() };

    // Start is called before the first frame update
    void Start()
    {
        CheckID(card1);
        CheckID(card2);
        CheckID(card3);
        CheckID(card4);
    }

    void CheckID(IDCard card)
    {
        string fullName = card.GetFullName();
        print("the full name is " + fullName);
    }
}
