using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchStatement : MonoBehaviour
{
    void CheckTemperature(float temp)
    {
        if (temp == 100)
        {
            // super hot
        }
        else if (temp == 80)
        {
            // really hot
        }
        else if (temp == 20)
        {
            // seems okay
        }
        else
        {
            // I dunno what to do with this value
        }

        switch (temp)
        {
            default:
                // I dunno what to do with this value
                break;


            case 100:
                // super hot
                print("");

                break;

            case 80:
                // really hot
                break;
        }
    }
}
