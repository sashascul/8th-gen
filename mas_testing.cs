using System.Collections;
using UnityEngine;

public class Mas_testing : MonoBehaviour {
    public GameObject [] objs;
    void Start ()
    {
        Instantiate(objs[0], objs[0].transform.position, Quaternion.identity);
    }
}