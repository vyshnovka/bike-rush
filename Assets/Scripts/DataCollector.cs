using System;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{
    public static int countLeft = 0;
    public static int countRight = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (other.transform.position.x > transform.position.x)
            {
                countLeft++;
            }
            else
            {
                countRight++;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (other.transform.position.x > transform.position.x)
            {
                countLeft--;
            }
            else
            {
                countRight--;
            }
        }
    }
}
