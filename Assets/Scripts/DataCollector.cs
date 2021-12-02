using System;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{
    public static int countLeft = 0;
    public static int countRight = 0;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Bicyclist":
                if (other.transform.position.x > transform.position.x)
                {
                    countLeft++;
                }
                else
                {
                    countRight++;
                }
                break;
            case "Obstacle":
                if (other.transform.position.x > transform.position.x)
                {
                    countLeft += 2;
                }
                else
                {
                    countRight += 2;
                }
                break;
            case "Character":
                if (other.transform.position.x > transform.position.x)
                {
                    countLeft += 3;
                }
                else
                {
                    countRight += 3;
                }
                break;
            default:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Bicyclist":
                if (other.transform.position.x > transform.position.x)
                {
                    countLeft--;
                }
                else
                {
                    countRight--;
                }
                break;
            case "Obstacle":
                if (other.transform.position.x > transform.position.x)
                {
                    countLeft -= 2;
                }
                else
                {
                    countRight -= 2;
                }
                break;
            case "Character":
                if (other.transform.position.x > transform.position.x)
                {
                    countLeft -= 3;
                }
                else
                {
                    countRight -= 3;
                }
                break;
            default:
                break;
        }
    }
}
