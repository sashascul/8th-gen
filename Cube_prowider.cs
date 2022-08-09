using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_prowider : MonoBehaviour {
    public GameObject abc;
    public float a = 2f;
    public float b = 30f;
        void Update ()
            {
                if (Input.GetKey(KeyCode.Keypad8))
                    {
                        abc.transform.Translate(Vector3.forward * -a * Time.deltaTime);
                    }
                if (Input.GetKey(KeyCode.Keypad2))
                    {
                        abc.transform.Translate(-Vector3.forward * -a * Time.deltaTime);
                    }
                if (Input.GetKey(KeyCode.Keypad4))
                    {
                        abc.transform.Rotate(Vector3.up * -b * Time.deltaTime);
                    }
                if (Input.GetKey(KeyCode.Keypad6))
                    {
                        abc.transform.Rotate(Vector3.up * b * Time.deltaTime);
                    }   
            }

}
