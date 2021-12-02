using System;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{
    public static int countLeft = 0;
    public static int countRight = 0;

    public void OnTriggerEnter(Collider other)
    {
        float thisPositionX = transform.position.x;
        float otherPositionX = other.transform.position.x;

        switch (other.gameObject.tag)
        {
            case "Bicyclist":
                if (otherPositionX > thisPositionX)
                {
                    countLeft++;
                }
                else
                {
                    countRight++;
                }
                break;
            case "Obstacle":
                if (otherPositionX > thisPositionX)
                {
                    countLeft += 2;
                }
                else
                {
                    countRight += 2;
                }
                break;
            case "Character":
                if (otherPositionX > thisPositionX)
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

    public void OnTriggerExit(Collider other)
    {
        float thisPositionX = transform.position.x;
        float otherPositionX = other.transform.position.x;

        switch (other.gameObject.tag)
        {
            case "Bicyclist":
                if (otherPositionX > thisPositionX)
                {
                    countLeft--;
                }
                else
                {
                    countRight--;
                }
                break;
            case "Obstacle":
                if (otherPositionX > thisPositionX)
                {
                    countLeft -= 2;
                }
                else
                {
                    countRight -= 2;
                }
                break;
            case "Character":
                if (otherPositionX > thisPositionX)
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
