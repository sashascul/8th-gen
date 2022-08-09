using System.Collections;
using UnityEngine;

public class Going_testing : MonoBehaviour {
    private Light myLight;
public GameObject obj;
public float b = 3f;
public float c = 50f;
    void Start ()
        {
            myLight = GetComponent <Light> ();
        }
    void Update ()
        {
            if (Input.GetKey(KeyCode.H))
                {
                    obj.transform.Translate(Vector3.forward * -b * Time.deltaTime);
                }
            if (Input.GetKey(KeyCode.Y))
                {
                    obj.transform.Translate(-Vector3.forward * -b * Time.deltaTime);
                }
            if (Input.GetKey(KeyCode.G))
                {
                    obj.transform.Rotate(Vector3.up, -c * Time.deltaTime);    
                }
            if (Input.GetKey(KeyCode.J))
                {
                    obj.transform.Rotate(Vector3.up, c * Time.deltaTime);
                }
        }
}
