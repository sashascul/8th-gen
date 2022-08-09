using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursue : MonoBehaviour {
    public Transform End;
    public GameObject abc;

	void Start () {
		
	}


    void Update ()
        {
           abc.transform.position = Vector3.MoveTowards(transform.position, End.position, Time.deltaTime);
	    }
}
