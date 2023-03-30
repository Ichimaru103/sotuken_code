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
    public GameObject box_gen;
    Vector3 boxL_pos;
    Vector3 boxR_pos;
    Vector3 sphereR_pos;
    Vector3 boxR_st;
    Vector3 boxL_st;
    Vector3 sphereR_st;

    Vector3 boxR_size;
    Vector3 boxL_size;
    Vector3 sphereR_size;

    public float pole_dis;

    float boxR_long;
    float boxL_long;
    float sphereR_long;

    bool flagL = false;
    bool flagR = false;
    bool flag_boxL = true;
    bool flag_boxR = true;
    bool flag_rb = true;

    bool flag_change = false;

   

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
        /*float temp = 0;
        float temp_s = 0;*/

        var rb_R = boxR.GetComponent<Rigidbody>();
        var rb_L = boxL.GetComponent<Rigidbody>();
        var rb_sphere = sphereR.GetComponent<Rigidbody>();

        boxL_pos = boxL.transform.position;
        boxR_pos = boxR.transform.position;
        sphereR_pos = sphereR.transform.position;

        boxR_size = boxR.transform.localScale;
        boxL_size = boxL.transform.localScale;
        sphereR_size = sphereR.transform.localScale;

        boxR_long = boxR_size.z / 2;
        boxL_long = boxL_size.z / 2;
        sphereR_long = sphereR_size.z / 2;
        /*  if(boxL.transform.position == boxL_st)
          {
              *//*KeepSize();*//*
              Debug.Log("keep");
          }*/


        if (boxL_pos.z - boxL_long >= pole_dis)
        {
            /*Debug.Log("yes");*/
            /*  pole_l.GetComponent<Renderer>().material.color = Color.red;
              pole_r.GetComponent<Renderer>().material.color = Color.red; //sakushi*/
           /* box_gen.GetComponent<Renderer>().material.color = Color.red*/;//box gen
            /* boxL_pos.z = boxL_long + pole_dis;
             boxL.transform.position = boxL_pos;*/
            /*if (flagL == true)
            {
                temp = boxL_pos.z;
                flagL = false;
                *//*Debug.Log("yes");*//*
            }*/

            /* boxL_pos.z = temp;
             boxL.transform.position = boxL_pos;*/
            /*rb_L.constraints = RigidbodyConstraints.FreezeAll;*/
            rb_L.constraints = rb_R.constraints;
        }
        else
        {
            /* pole_l.GetComponent<Renderer>().material.color = Color.white;
             pole_r.GetComponent<Renderer>().material.color = Color.white; //sakushi*/
           /* box_gen.GetComponent<Renderer>().material.color = Color.white;*/
           /* flagL = true;*/
            rb_L.constraints = rb_sphere.constraints;
        }
       /* if (boxR_pos.z - boxR_long >= pole_dis || sphereR_pos.z - sphereR_long >= pole_dis)
        {

            pole_r.GetComponent<Renderer>().material.color = Color.red;
            if (flagR == true)
            {
                temp = boxR_pos.z;
                temp_s = sphereR_pos.z;
                flagR = false;
                *//* Debug.Log("temp " + temp);*/
                /* Debug.Log("yes");*//*



            }
            rb_R.constraints = RigidbodyConstraints.FreezeAll;
            *//*       boxR_st.z = temp;
                   boxR.transform.position = boxR_st;
                   Debug.Log("st " + boxR_st);*/
            /*boxR_pos.z = temp;
            boxR.transform.position = boxR_pos;*//*



            sphereR_pos.z = temp_s;
            sphereR.transform.position = sphereR_pos;


        }
        else
        {
            *//*pole_r.GetComponent<Renderer>().material.color = Color.white;*/
            /*if (flag_rb == true)
            {
                var st_rb = boxR.GetComponent<Rigidbody>();
                rb.constraints = st_rb.constraints;
                flag_rb = false;
            }*//*
            rb_R.constraints = rb_sphere.constraints;


        }*/

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            gen();
          
         
        }*/





        /*    void KeepSize()
            {
                boxL_pos = boxL.transform.position;
                boxR_pos = boxR.transform.position;
                sphereR_pos = sphereR.transform.position;

                boxR_size = boxR.transform.localScale;
                boxL_size = boxL.transform.localScale;
                sphereR_size = sphereR.transform.localScale;

                boxR_long = boxR_size.z / 2;
                boxL_long = boxL_size.z / 2;
                sphereR_long = sphereR_size.z / 2;
            }*/
    }

    public void gen()
    {
        
        boxR.transform.position = boxR_st;
        boxL.transform.position = boxL_st;
        sphereR.transform.position = sphereR_st;
    }
}
