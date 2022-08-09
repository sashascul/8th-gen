using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour {

    public Text point;
    private int count = 0;

	void Start ()
        {
            SetCount();
	    }
    void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Point")
                {
                    Destroy(other.gameObject);
                    count++;
                    other.gameObject.tag = "Player";
                    SetCount();
                }
        }
    void SetCount ()
        {
            point.text = "Point:" + count.ToString() + "/30";
        }
}
