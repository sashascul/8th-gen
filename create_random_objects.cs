using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class create_random_objects : MonoBehaviour
{
    public GameObject abc;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.M))
        {
            StartCoroutine(instabc());
        }
    }
        IEnumerator instabc()
        {
            while (true)
            {
                Instantiate(abc, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
                yield return new WaitForSeconds(2);
            }
        }
}