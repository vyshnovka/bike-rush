using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Untagged"))
        {
            if (DataCollector.countRight >= DataCollector.countLeft)
            {
                transform.parent.Translate(Vector3.right * 1f);
                //transform.parent.position += Vector3.Lerp(Vector3.right, Vector3.right, 0.5f);
            }
            else
            {
                transform.parent.Translate(Vector3.left * 1f);
                //transform.parent.position += Vector3.Lerp(Vector3.left, Vector3.left, 0.5f);
            }
        }
    }
}
