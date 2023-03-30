using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size_change : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boxR;
    public GameObject sphereR;
    GameObject boxL;
    public GameObject gen;
    public GameObject pole;
    public GameObject ex2;
    
    

    Vector3 size_boxR;
    Vector3 size_sphereR;
    Vector3 size_L;
    Vector3 st_sizebox;
    Vector3 st_sizesphere;

    Vector3 pos_boxR;
    Vector3 st_posboxR;
    Vector3 st_posboxL;
    Vector3 offset;

    Vector3 box_size;

    Vector3 temp;
    Vector3 gen_posboxR;
    Vector3 gen_posboxL;
    Vector3 pos_mid;

   

    float set_tempboxR;
    float set_tempboxL;
    float temp_long;
    public float v;
    float set;
   

    public float x, y, z;
    bool flag_R = false;
    bool flag_L = false;
    bool flag_big = false;

    /*public bool flag_change;*/
    void Start()
    {
        /* boxR = GameObject.FindGameObjectWithTag("boxR");*/
       /* boxL = GameObject.FindGameObjectWithTag("boxL");*/
        st_sizebox = boxR.transform.localScale;
        st_sizesphere = sphereR.transform.localScale;
        st_posboxR = boxR.transform.position;

        Debug.Log("st_posboxR" + st_posboxR);
        /*st_posboxL = boxL.transform.position;*/
        temp = st_sizebox;



        temp_long = st_posboxR.z;
        gen_posboxR = st_posboxR;
        /*gen_posboxL = st_posboxL;*/
        set_tempboxR = st_posboxR.z;
        /*set_tempboxL = st_posboxL.z;*/
        set = 0;
        pos_mid = new Vector3(0, -0.27f, 0.65f);

        Debug.Log("st_posboxR after " + st_posboxR);

    }

    // Update is called once per frame
    void Update()
    {
        


        box_size = boxR.transform.localScale;
       /* int count = 0;*/
        // smoller box
        Vector3 time_size = new Vector3(x, y, z);
       /* float dis;*/
        float front;

        if (Input.anyKeyDown)
        {
            temp = st_sizebox;
            boxR.transform.localScale = st_sizebox;
            set = 0;
        }

        pos_boxR = boxR.transform.position;

        /*if (gen.GetComponent<box_gen>().flag_gen)
        {
            pole.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            pole.GetComponent<Renderer>().material.color = Color.white;
        }*/

        /* dis = pos_boxR.z - st_posboxR.z;*/
      

        front = pos_boxR.z - box_size.z / 2 - set;
        /* dis = front - 0.3f - offset;
         Debug.Log("dis" + dis);
         dis = dis * 1000;
         a = Mathf.Floor(dis);
         dis = a / 1000;
         Debug.Log("dis " + dis);*/
        /*Debug.Log("front  " + front);
        Debug.Log("offset" + set);*/

        /*if (Input.GetKeyDown(KeyCode.D))
        {
            flag_change = true;
            Debug.Log("henkou");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            flag_change = false;
            Debug.Log("Nohenkou");
        }*/
        /*Debug.Log("front " + front);*/
        if(ex2.GetComponent<Experiment2>().flag_change)
        {
            /*Debug.Log("hennkou");*/
            if (front >= 0.325f && set < 0.3f)
            {
                temp = temp - time_size;
                boxR.transform.localScale = temp;
                st_posboxR.z = pos_boxR.z;
                set = set + 0.025f;

               /* count++;
                Debug.Log("kaisuu" + count);*/
                /* Debug.Log("infront" + front);*/

            }
            else if (set >= 0.3f)
            {
                Vector3 adj_pos;
                /*Vector3 adj_size;*/
                front = 0.6f;
                adj_pos = pos_mid - new Vector3(0, 0, 0.0009f);
                boxR.transform.position = adj_pos;
                boxR.transform.localScale = new Vector3(0.0982f, 0.0982f, 0.0982f);
                gen.GetComponent<Renderer>().material.color = Color.red;
            }
            /* if (pos_boxR.z == st_posboxR.z)
             {
                 boxR.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
             }*/
        }
        else
        {
            /*Debug.Log("sonomamam");*/
            if (front >= 0.6f)
            {
                pos_boxR.z = 0.65f;
                boxR.transform.position = pos_boxR;
                gen.GetComponent<Renderer>().material.color = Color.red;
            }
        }
        
       
        
        if (gen.GetComponent<box_gen>().flag_gen)
        {
           /* st_posboxR = boxR.transform.position;
            temp = st_sizebox;*/
            boxR.transform.localScale = st_sizebox;
            temp = st_sizebox;
            /* flag_big = false;*/
            set = 0;
            gen.GetComponent<Renderer>().material.color = Color.white;
            generate();
        }


        /*   size_sphereR = sphereR.transform.localScale;
           size_L = boxL.transform.localScale;*/
        /*
                if (Input.GetKeyDown(KeyCode.S))
                {
                    size_boxR = st_sizebox;

                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                    size_sphereR = st_sizebox;

                }*/

        // display most bigger boxR.z
        /*pos_boxR = boxR.transform.position;*/

      /*  if (pos_boxR.z > temp_long)
        {
            temp_long = pos_boxR.z;
            Debug.Log("pos " + pos_boxR);
            Debug.Log("temp" + temp_long);

        }
        if (gen.GetComponent<box_gen>().flag_gen)
        {
            generate();
            Debug.Log("temp " + temp_long);
            temp_long = st_posboxR.z;
        }
*/




        if (boxR.activeSelf)
        {

            sphereR.transform.localScale = st_sizebox;

        }
        /*if (sphereR.activeSelf)
        {
            boxR.transform.localScale = st_sizesphere;
        }*/

        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (boxR.activeSelf)
            {
                SizeupboxR();


            }
            if (sphereR.activeSelf)
            {
                SizeupsphereR();

            }




        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {


            if (boxR.activeSelf)
            {
                SizedownboxR();

            }
            if (sphereR.activeSelf)
            {
                SizedownsphereR();

            }


        }*/
        /* if (Input.GetKeyDown(KeyCode.LeftArrow))
         {

             SizedownL();

         }

         if (Input.GetKeyDown(KeyCode.RightArrow))
         {

             SizeupL();

         }*/



    }

    /*void SizeupboxR()
    {
        size_boxR.x = size_boxR.x + v;
        size_boxR.y = size_boxR.y + v;
        size_boxR.z = size_boxR.z + v;
        boxR.transform.localScale = size_boxR;
        flag_R = true;
        flag_L = false;

        SetOffAdd();






    }
    void SizedownboxR()
    {
        size_boxR.x = size_boxR.x - v;
        size_boxR.y = size_boxR.y - v;
        size_boxR.z = size_boxR.z - v;
        boxR.transform.localScale = size_boxR;

        *//*set = (st_posboxR.z - 0.05f) - v / 2;
        pos_boxR.z = st_posboxR.z - set;
        boxR.transform.position = pos_boxR;*//*
        flag_R = true;
        flag_L = false;
        SetoffSub();


    }
    void SizeupsphereR()
    {
        size_sphereR.x = size_sphereR.x + v;
        size_sphereR.y = size_sphereR.y + v;
        size_sphereR.z = size_sphereR.z + v;
        sphereR.transform.localScale = size_sphereR;

        SetOffAdd();

    }
    void SizedownsphereR()
    {
        size_sphereR.x = size_sphereR.x - v;
        size_sphereR.y = size_sphereR.y - v;
        size_sphereR.z = size_sphereR.z - v;
        sphereR.transform.localScale = size_sphereR;

        SetoffSub();
    }
    void SizeupL()
    {
        size_L.x = size_L.x + v;
        size_L.y = size_L.y + v;
        size_L.z = size_L.z + v;
        boxL.transform.localScale = size_L;
        flag_R = false;
        flag_L = true;

        SetOffAdd();
    }
    void SizedownL()
    {
        size_L.x = size_L.x - v;
        size_L.y = size_L.y - v;
        size_L.z = size_L.z - v;
        boxL.transform.localScale = size_L;
        flag_R = false;
        flag_L = true;

        SetoffSub();
    }

    void SetOffAdd()
    {
        *//*float temp;*//*
        if(flag_R == true)
        {
            set_tempboxR += 0.0125f;
            offset = new Vector3(st_posboxR.x, st_posboxR.y, set_tempboxR);
            Debug.Log("add_before " + st_posboxR);
            *//*Debug.Log("befor_add " + temp);*//*
            boxR.transform.position = offset;
            gen_posboxR = boxR.transform.position;
            *//*Debug.Log("after_add " + temp);*//*
            Debug.Log("add_after " + st_posboxR);
            flag_R = false;
        }
       else if(flag_L == true)
        {
            set_tempboxL += 0.0125f;
            offset = new Vector3(st_posboxL.x, st_posboxL.y, set_tempboxL);
            Debug.Log("add_before " + st_posboxL);
            *//*Debug.Log("befor_add " + temp);*//*
            boxL.transform.position = offset;
            gen_posboxL = boxL.transform.position;
            *//*Debug.Log("after_add " + temp);*//*
            Debug.Log("add_after " + st_posboxL);
            flag_L = false;
        }
        
      
    }
    void SetoffSub()
    {
        
        if(flag_R == true)
        {
            set_tempboxR -= 0.0125f;
            offset = new Vector3(st_posboxR.x, st_posboxR.y, set_tempboxR);
            Debug.Log("sub_before " + st_posboxR);
            *//* Debug.Log("befor_sub " + temp);*//*
            boxR.transform.position = offset;
            gen_posboxR = boxR.transform.position;
            *//*Debug.Log("after_sub " + temp);*//*
            Debug.Log("sub_affter " + st_posboxR);
            flag_R = false;
        }
        else if(flag_L == true)
        {
            set_tempboxL -= 0.0125f;
            offset = new Vector3(st_posboxL.x, st_posboxL.y, set_tempboxL);
            Debug.Log("sub_before " + st_posboxL);
            *//* Debug.Log("befor_sub " + temp);*//*
            boxL.transform.position = offset;
            gen_posboxL = boxL.transform.position;
            *//*Debug.Log("after_sub " + temp);*/
   /* Debug.Log("sub_affter " + st_posboxL);
            flag_L = false;
        }
        
    }*/

    public void generate()
{
    boxR.transform.position = gen_posboxR;
    boxL.transform.position = gen_posboxL;
}

   

}
