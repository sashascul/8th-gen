using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine;
using System;

public class InPoint : MonoBehaviour {

    void Start ()
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            gameObject.SetActive(false);
            gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
            gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
            other.gameObject.SetActive(true);
            other.gameObject.AddComponent<ThirdPersonCharacter>();
            other.gameObject.AddComponent<ThirdPersonUserControl>();
            other.gameObject.AddComponent<Animator>();
            other.gameObject.tag = "Player";
        }
    }
     
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
            {
                gameObject.GetComponent<BoxCollider>().enabled = true;
            }
    }
}
