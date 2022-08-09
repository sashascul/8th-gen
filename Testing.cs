using System.Collections;
using UnityEngine;

public class Testing : MonoBehaviour {
    public GameObject a;
        void Start ()
            {
                Instantiate(a, a.transform.position, Quaternion.identity);
            }

}
