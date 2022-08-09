using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatGun : MonoBehaviour {

    public GameObject GunNumber1;
    public GameObject GunNumber2;
    private int MaxGun = 2;
    private int Repeater;
        void Start ()
            {
                GunNumber2.SetActive (false);
            }
        void Update ()
            {
                if (Repeater == 0)
                    {
                        GunNumber1.SetActive (true);
                        GunNumber2.SetActive (false);
                    }
                if (Repeater == 1)
                    {
                        GunNumber1.SetActive (false);
                        GunNumber2.SetActive (true);
                    }
                if (Repeater <= 0)
                    {
                        Repeater = 0;
                    }
                if (Repeater >= MaxGun)
                    {
                        Repeater = MaxGun;
                    }
                if (Input.GetKeyUp(KeyCode.Alpha2))
                    {
                        Repeater++;
                    }
                if (Input.GetKeyUp(KeyCode.Alpha1))
                    {
                        Repeater--;
                    }
            }
}
