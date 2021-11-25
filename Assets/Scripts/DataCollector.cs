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
                //transform.Translate(Vector3.left * 1f);
            }
            else
            {
                countRight++;
                //transform.Translate(Vector3.right * 1f);
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
