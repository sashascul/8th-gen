using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBeat : MonoBehaviour {
    public GameObject objectbeat;
    public GameObject objectdead;
        void OnTriggerEnter (Collider other)
            {
                if (other.tag == "Manbeat")
                    {
                        objectbeat.SetActive (false);
                        objectdead.SetActive (true);
                        Instantiate (objectdead, transform.position, Quaternion.identity);
                    }
            }
}
