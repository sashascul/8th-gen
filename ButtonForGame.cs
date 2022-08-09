using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayOnline ()
        {
            SceneManager.LoadScene (1);
        }
    public void PlayThroughTheAccessPointWIFI ()
        {
            SceneManager.LoadScene (2);
        }
    public void AboutTheGame ()
        {
            SceneManager.LoadScene (3);
        }
    public void  Developers ()
        {
            SceneManager.LoadScene (4);
        }
    public void Back ()
        {
            SceneManager.LoadScene (5);
        }


}
