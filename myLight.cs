using System.Collections;
using UnityEngine;

public class myLight : MonoBehaviour
{
    private Light myLights;
    public GameObject obj;
    void Start()
    {
        myLights = GetComponent<Light>();
        print("I - light, Y - false, U - true, O - yellow, P - green");
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
            {
                myLights.enabled = !myLights.enabled; 
            }
        if (Input.GetKeyUp(KeyCode.Y))
            {
                obj.SetActive(false);
            }
        if (Input.GetKeyUp(KeyCode.U))
            {
                obj.SetActive(true);
            }    
        if (Input.GetKeyUp(KeyCode.O))
            {
                obj.GetComponent <Renderer>().material.color = Color.yellow;
            }
        else if (Input.GetKeyUp(KeyCode.P))
            {
                obj.GetComponent<Renderer>().material.color = Color.green;
            }
    }
}