using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_change : MonoBehaviour
{
    public GameObject pole_r;
    public GameObject pole_l;
    public GameObject boxR;
    public GameObject boxL;
    public GameObject boxR_pre;
    public GameObject boxL_pre;
    public GameObject sphereR;
    Vector3 boxL_pos;
    Vector3 boxR_pos;
    Vector3 sphereR_pos;
    Vector3 boxR_st;
    Vector3 boxL_st;
    Vector3 sphereR_st;
    bool flagL = false;
    bool flagR = false;
    public bool flag_boxL = false;
    public bool flag_boxR = false;

    public static color_change instance;

    // Start is called before the first frame update
    void Start()
    {
        boxR_st = boxR.transform.position;
        boxL_st = boxL.transform.position;
        sphereR_st = sphereR.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        boxL_pos = boxL.transform.position;
        boxR_pos = boxR.transform.position;
        sphereR_pos = sphereR.transform.position;

        if (boxL_pos.z >= 0.55 )
        {
            pole_l.GetComponent<Renderer>().material.color = Color.red;

        }
        if (boxR_pos.z >= 0.55 || sphereR_pos.z >= 0.55)
        {
            pole_r.GetComponent<Renderer>().material.color = Color.red;

        }
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gen();
          
         
        }



    }
    public void gen()
    {
        pole_l.GetComponent<Renderer>().material.color = Color.white;
        pole_r.GetComponent<Renderer>().material.color = Color.white;
        boxR.transform.position = boxR_st;
        boxL.transform.position = boxL_st;
        sphereR.transform.position = sphereR_st;

        /*   Destroy(boxL);
           Destroy(boxR);
           boxL = Instantiate(boxL_pre, boxL_st, Quaternion.identity);
           boxR = Instantiate(boxR_pre, boxR_st, Quaternion.identity);
           Debug.Log("spacekey");*/
    }
}
