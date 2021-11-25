using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (DataCollector.countRight > DataCollector.countLeft)
            {
                transform.parent.Translate(Vector3.right * 1f);
            }
            else
            {
                transform.parent.Translate(Vector3.left * 1f);
            }
        }
    }
}
