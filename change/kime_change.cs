using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kime_change : MonoBehaviour
{
    public GameObject kime;
    Vector3 kime_pos;
    Vector3 kime_st;

    public GameObject kime6;
    Vector3 kime6_pos;
    Vector3 kime6_st;
    int rnd;
    // Start is called before the first frame update
    void Start()
    {
         rnd = 1;
      /*  kime_st = kime.transform.position;*/
        kime6_st = kime6.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       /* kime_pos = kime_st;*/
        kime6_pos = kime6_st;
        if (Input.anyKeyDown)
        {
            rnd = Random.Range(1, 4);
        }
        switch (rnd)
        {
            case 1:
                kime_pos.z = kime_pos.z + 0.03f;

                kime.transform.position = kime_pos;
                kime6_pos.z = kime6_pos.z + 0.03f;
                kime6.transform.position = kime6_pos;
                break;

            case 2:
                kime_pos.z = kime_pos.z + 0.06f;
                kime.transform.position = kime_pos;
                kime6_pos.z = kime6_pos.z + 0.06f;
                kime6.transform.position = kime6_pos;
                break;
            case 3:
                kime_pos.z = kime_pos.z + 0.08f;
                kime.transform.position = kime_pos;
                kime6_pos.z = kime6_pos.z + 0.08f;
                kime6.transform.position = kime6_pos;
                break;
        }

    }
}
