using UnityEngine;
using System.Collections;

public class mas_rand : MonoBehaviour
{
    public GameObject[] objss;
    void Start()
    {
        int rand = Random.Range(0, objss.Length - 1);
        Instantiate (objss[rand], objss[rand].transform.position, Quaternion.identity);
    }
}