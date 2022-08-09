using System.Collections;
using UnityEngine;

public class ChildbeatBill : MonoBehaviour {

    public GameObject child;    // in programm there are The Child and The Child 1;
    public GameObject deadBill;
        void Start ()
            {   
                deadBill.SetActive (false);
            }
        void OnTriggerEnter (Collider other)
            {
                if (other.tag == "Player")
                    {
                        child.GetComponent <Animator>().SetTrigger ("Attack");
                        deadBill.SetActive (true);
                    }
            }
        void OnTriggerExit (Collider other)
            {
                if (other.tag == "Player")
                {
                    deadBill.SetActive (false); 
                }
            }
}
