using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position_change : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box;
    Vector3 box_pos;
    Vector3 box_st;
    void Start()
    {
        box_st = box.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            box_pos = new Vector3(0, -0.27f, 0.65f);
            box.transform.position = box_pos;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            box_pos = new Vector3(0, -0.27f, 0.7f);
            box.transform.position = box_pos;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            box_pos = new Vector3(0, -0.27f, 0.75f);
            box.transform.position = box_pos;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            box_pos = new Vector3(0, -0.27f, 0.675f);
            box.transform.position = box_pos;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            box_pos = new Vector3(0, -0.27f, 0.725f);
            box.transform.position = box_pos;
        }
       
    }
}
