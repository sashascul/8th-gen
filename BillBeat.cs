using System.Collections;
using UnityEngine;

public class BillBeat : MonoBehaviour
{
    public GameObject objectbeat;
    public GameObject objectdead;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "deadBill")
        {
            objectbeat.SetActive(false);
            objectdead.SetActive(true);
            Instantiate (objectdead, transform.position, Quaternion.identity);
        }
    }
}
