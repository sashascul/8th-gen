using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoMyChild : MonoBehaviour {

    public GameObject child1;
        void OnTriggerEnter (Collider other)
            {
                if (other.tag == "Player")
                    {
                        child1.GetComponent <Animator>().SetTrigger ("Go");
                    }
            }
        void OnTriggerExit (Collider other)
            {
                if (other.tag == "Player")
                    {
                        child1.GetComponent <Animator>().SetTrigger ("Go");
                       // child1.GetComponent <Animator>().SetTrigger ()
                    }
            }
}
