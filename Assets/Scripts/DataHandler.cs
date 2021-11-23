using System;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (other.transform.position.x > transform.position.x)
            {
                transform.Translate(Vector3.left * 1f);
            }
            else
            {
                transform.Translate(Vector3.right * 1f);
            }
        }
    }
}
