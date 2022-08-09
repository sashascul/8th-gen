using System.Collections;
using UnityEngine;

public class AK : MonoBehaviour {
public Transform bullet;
public int BulletForce = 5000;
public int Magazin = 7;
public AudioClip Fire;
public AudioClip AndFire;
void Update()
{
    if (Input.GetMouseButtonDown(0) &Magazin > 0)
    {
        Transform BulletInstance = (Transform) Instantiate (bullet, GameObject.Find("Spawn").transform.position, Quaternion.identity);
        BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
        Magazin = Magazin - 1;
        GetComponent<AudioSource>().PlayOneShot(Fire);
        GetComponent<AudioSource>().PlayOneShot(AndFire);
    }
    if (Input.GetKeyDown(KeyCode.R))
    {
        Magazin = 7;
    }
}
}
