using System.Collections;
using UnityEngine;

public class ManBeat2 : MonoBehaviour {
    public GameObject Player;
    public GameObject Shot1;
    void Start()
        {
                    Shot1.SetActive(false);
        }
    void Update()
        {
            if (Input.GetMouseButtonDown(0))
                {
                    Player.GetComponent<Animator>().SetTrigger("Shot1");
                    Shot1.SetActive(true);
                }
            if (Input.GetMouseButtonUp(0))
                {
                    Player.GetComponent<Animator>().SetTrigger("Idle1");
                    Shot1.SetActive(false);
                }
        }
}
