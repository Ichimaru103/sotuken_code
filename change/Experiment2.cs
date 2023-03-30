using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiment2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rane_str;
    public GameObject rane_mid;
    public GameObject box;
    public GameObject kime;
    public GameObject lane;
    public GameObject gen;

    Vector3 rane_str_st;
    Vector3 rane_mid_st;
    Vector3 box_st;
    Vector3 kime_st;
    Vector3 lane_st;
    Vector3 gen_st;

    Vector3 hide;
    Vector3 hide_gen;
    Vector3 hide_box;
    Vector3 kime_pos;
    public float cd;

    int rnd = 0;
    int change = 0;
    public bool flag_change;
    bool flag_P = false;



    void Start()
    {
        rane_mid_st = rane_mid.transform.position;
        rane_str_st = rane_str.transform.position;
        box_st = box.transform.position;
        kime_st = kime.transform.position;
        lane_st = lane.transform.position;
        /*gen_st = gen.transform.position;*/

     


        hide = new Vector3(0, 10f, -30f);
        hide_box = new Vector3(0, 10f, -30f);
        hide_gen = new Vector3(0, 13f, -30f);
        rane_str.transform.position = hide;
        rane_mid.transform.position = hide;
       /* box.transform.position = hide_box;*/
        kime.transform.position = hide;
        lane.transform.position = hide;
        /* gen.transform.position = hide_gen;*/
        gen.SetActive(false);
        box.SetActive(false);


        kime_pos = kime_st;
    }


    // Update is called once per frame
    void Update()
    {

        
        if (Input.anyKeyDown)
        {
            /*box.transform.position = box_st;*/
            /*gen.GetComponent<Renderer>().material.color = Color.white;*/
            gen.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rane_str.transform.position = hide;
                rane_mid.transform.position = hide;
               /* box.transform.position = hide_box;*/
                kime.transform.position = hide;
                lane.transform.position = hide;
                /* gen.transform.position = hide_gen;*/
                box.transform.position = box_st;
                gen.SetActive(false);
                box.SetActive(false);
                cd = 1f;
            }
            else
            {
                rnd = Random.Range(0, 4);


                kime.transform.position = kime_pos;
                lane.transform.position = lane_st;
                /*gen.transform.position = gen_st;*/

                gen.SetActive(true);
                box.SetActive(true);


                if (Input.GetKeyDown(KeyCode.A))
                {
                    rane_str.transform.position = rane_str_st;
                   /* box.transform.position = box_st;*/
                    change = 0;
                    cd = 0.8f;
                }
   
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    rane_str.transform.position = rane_str_st;
                   /* box.transform.position = box_st;*/
                    change = 0;
                    cd = 1f;
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    rane_str.transform.position = rane_str_st;
                    box.transform.position = box_st;
                    change = 0;
                    cd = 1.2f;
                }
             
                else if (Input.GetKeyDown(KeyCode.J))
                {
                    rane_mid.transform.position = rane_mid_st;
                    /*box.transform.position = box_st;*/
                    change = 1;
                    cd = 0.8f;

                }
                else if (Input.GetKeyDown(KeyCode.K))
                {
                    rane_mid.transform.position = rane_mid_st;
                    /*box.transform.position = box_st;*/
                    change = 1;
                    cd = 1f;
                }
                else if (Input.GetKeyDown(KeyCode.L))
                {
                    rane_mid.transform.position = rane_mid_st;
                  /*  box.transform.position = box_st;*/
                    change = 1;
                    cd = 1.2f;
                }

                else if (Input.GetKeyDown(KeyCode.P)) {

                    rane_str.transform.position = rane_str_st;
                   /* gen.GetComponent<Renderer>().material.color = Color.blue;*/
                    /* box.transform.position = box_st;*/
                    change = 0;
                    cd = 1f;
                    

                }
               /* else
                {
                    rnd = Random.Range(0, 4);


                    kime.transform.position = hide;
                    lane.transform.position = hide;
                    *//*gen.transform.position = gen_st;*//*

                    gen.SetActive(false);
                    box.SetActive(false);
                    cd = 1f;
                }*/
            }
            
           
        }
        

        

        switch (change)
        {
            case 0:
                flag_change = false;
                rane_mid.transform.position = hide;
                
                break;
            case 1:
                flag_change = true;
                rane_str.transform.position = hide;
                break;

        }

        /*if (gen.GetComponent<box_gen>().flag_gen)
        {
            *//* st_posboxR = boxR.transform.position;
             temp = st_sizebox;*//*
            boxR.transform.localScale = st_sizebox;
            *//* flag_big = false;*//*
            set = 0;
            gen.GetComponent<Renderer>().material.color = Color.white;
            generate();
        }*/


    }
}
