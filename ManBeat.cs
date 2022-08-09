using System.Collections;
using UnityEngine;

public class ManBeat : MonoBehaviour {
    public GameObject Player;
    public GameObject Shot;

	void Start ()
        {
            Shot.SetActive(false);
        }
    void Update ()
        {
            if (Input.GetMouseButtonDown (0))
                {
                    Player.GetComponent <Animator>().SetTrigger ("Shot");
                    Shot.SetActive (true);
                }
            if (Input.GetMouseButtonUp (0))
                {
                    Player.GetComponent <Animator>().SetTrigger ("Idle");
                    Shot.SetActive (false);
                }
	    }
}
