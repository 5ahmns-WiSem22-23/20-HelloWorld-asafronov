using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public string state = "idle";

    public int health = 100;

    public int damage = 25;

    void Update()
    {
        if (state == "idle")
        {
            Debug.Log("Das Objekt ist im Idle-Zustand");
        }
        else if (state == "attacking")
        {
            Debug.Log("Das Objekt greift an!");
        }
        else
        {
            Debug.Log("Das Objekt befindet sich in einem unbekannten Zustand");
        }

        switch (health)
        {
            case 100:
                Debug.Log("Das Objekt ist vollständig gesund");
                break;
            case 50:
                Debug.Log("Das Objekt hat die Hälfte seiner Gesundheit verloren");
                break;
            case 0:
                Debug.Log("Das Objekt hat keine Gesundheit mehr und ist besiegbar");
                break;
            default:
                Debug.Log("Das Objekt hat noch Gesundheit, aber es ist nicht vollständig gesund");
                break;
        }

        if(health == 100)
        {
            if(state == "attacking")
            {
                Debug.Log("Das Object attackiert mit voller Gesundheit");
            }
        }

        if(health <= 10)
        {
            if(state == "attacking")
            {
                Debug.Log("Das Object attackiert mit kaum Gesundheit");
            }
        }

    }
}
