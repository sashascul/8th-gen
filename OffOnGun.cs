using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffOnGun : MonoBehaviour {
    public GameObject Player;

    void Start ()
        {
            Player.GetComponent<ManBeat>(). enabled = true;
            Player.GetComponent<ManBeat2>(). enabled = false;
        }
    void Update ()
        {
            if (Input.GetKey(KeyCode.Alpha1))
                {
                    Player.GetComponent<ManBeat>(). enabled = true;
                    Player.GetComponent<ManBeat2>(). enabled = false;
                }
            if (Input.GetKey(KeyCode.Alpha2))
                {
                    Player.GetComponent<ManBeat>(). enabled = false;
                    Player.GetComponent<ManBeat2>(). enabled = true;
                }
        }
}
