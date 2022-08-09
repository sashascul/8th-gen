using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Point : MonoBehaviour {

    void Start ()
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
     void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Point")
                {
                    gameObject.GetComponent<Animator>().enabled = false;
                    gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
                    gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
                    other.gameObject.AddComponent<Animator>();
                    other.gameObject.AddComponent<ThirdPersonCharacter>();
                    other.gameObject.AddComponent<ThirdPersonUserControl>();
                    other.gameObject.tag = "Player";
                }
        }   
    void Update ()
        {
            if (Input.GetKey(KeyCode.Alpha1))
                {
                    gameObject.GetComponent<BoxCollider>().enabled = true;
                }
            if (Input.GetKey(KeyCode.Alpha2))
                {
                    gameObject.GetComponent<BoxCollider>().enabled = false;
                }
        }
}
