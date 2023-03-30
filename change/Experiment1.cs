using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiment1 : MonoBehaviour
{
    public GameObject rane_straight;
    public GameObject rane_mid;
   

    public GameObject box;
    public GameObject wall;
    public GameObject hikari;
    public GameObject kime;
    public GameObject line;

    float timer = 0;
    float interval = 3;
  
    Vector3 pos_short;
    Vector3 pos_semi_short;
    Vector3 pos_mid;
    Vector3 pos_semi_long;
    Vector3 pos_long;

    Vector3 box_size;

    Vector3 hide;
    Vector3 offset_str;
    Vector3 offset_mid;
    Vector3 offset_box;
    Vector3 offset_kime;
    Vector3 kime_st;
    Vector3 line_st;

    Vector3 pos_adj;

    int size = 0;
    int rnd = 0;

    bool flag_timer = false;
    bool flag_line = false;

    
    // Start is called before the first frame update
    void Start()
    {
        offset_str = rane_straight.transform.position;
        offset_mid = rane_mid.transform.position;
        offset_box = box.transform.position;
        offset_kime = kime.transform.position;


        kime_st = offset_kime;
        line_st = line.transform.position;


        /* rane_mid.transform.position = hide;
         kime.SetActive(false);
         box.SetActive(false);*/
        box_size = box.transform.localScale;
        hide = new Vector3(0, 10f, -30f);
        pos_short = new Vector3(0, -0.27f, 0.6f);
        pos_semi_short = new Vector3(0, -0.27f, 0.625f);
        pos_mid = new Vector3(0, -0.27f, 0.65f);
        pos_semi_long = new Vector3(0, -0.27f, 0.675f);
        pos_long = new Vector3(0, -0.27f, 0.7f);

        rane_straight.transform.position = hide;
        rane_mid.transform.position = hide;
        box.transform.position = hide;
        kime.transform.position = hide;
        line.transform.position = hide;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        var rb_box = box.GetComponent<Rigidbody>();
        /*rb_box.constraints = RigidbodyConstraints.FreezeAll;*/

        offset_kime = kime_st;
       
        if (Input.anyKeyDown)
        {
            flag_timer = false;


            if (Input.GetKeyDown(KeyCode.Space))
            {
                rane_straight.transform.position = hide;
                rane_mid.transform.position = hide;
                box.transform.position = hide;
                kime.transform.position = hide;
                line.transform.position = hide;
                flag_line = false;
            }
            // don't move
            /*  else
              {
                  kime.transform.position = kime_st;
              }*/
            // move
            else
            {
                line.transform.position = line_st;
                rnd = Random.Range(0, 4);

             
                // Straight
                if (Input.GetKeyDown(KeyCode.A))
                {
                    rane_straight.transform.position = offset_str;
                    rane_mid.transform.position = hide;


                    box.transform.position = pos_short;
                    size = 0;
                    flag_line = true;

                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    rane_straight.transform.position = offset_str;
                    rane_mid.transform.position = hide;

                    box.transform.position = pos_semi_short;

                    size = 0;
                    flag_line = true;
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    rane_straight.transform.position = offset_str;
                    rane_mid.transform.position = hide;


                    box.transform.position = pos_mid;
                    size = 0;
                    flag_line = true;


                }
                else if (Input.GetKeyDown(KeyCode.F))
                {
                    rane_straight.transform.position = offset_str;
                    rane_mid.transform.position = hide;


                    box.transform.position = pos_semi_long;
                    size = 0;
                    flag_line = true;

                }
                else if (Input.GetKeyDown(KeyCode.G))
                {
                    rane_straight.transform.position = offset_str;
                    rane_mid.transform.position = hide;


                    box.transform.position = pos_long;
                    size = 0;
                    flag_line = true;
                }

                // sakushi
                else if (Input.GetKeyDown(KeyCode.H))
                {
                    rane_straight.transform.position = hide;
                    rane_mid.transform.position = offset_mid;

                    pos_adj = pos_short - new Vector3(0, 0, 0.00075f);
                    box.transform.position = pos_adj;

                    size = 1;
                    flag_line = true;
                }
                else if (Input.GetKeyDown(KeyCode.J))
                {
                    rane_straight.transform.position = hide;
                    rane_mid.transform.position = offset_mid;

                    pos_adj = pos_semi_short - new Vector3(0, 0, 0.0008f);
                    box.transform.position = pos_adj;
                    size = 2;
                    flag_line = true;
                }
                else if (Input.GetKeyDown(KeyCode.K))
                {
                    float temp;
                    rane_straight.transform.position = hide;
                    rane_mid.transform.position = offset_mid;

                    pos_adj = pos_mid - new Vector3(0, 0, 0.0009f);

                  

                    box.transform.position = pos_adj;
                    size = 3;
                    flag_line = true;
                }
                else if (Input.GetKeyDown(KeyCode.L))
                {
                    float temp;
                    rane_straight.transform.position = hide;
                    rane_mid.transform.position = offset_mid;

                    pos_adj = pos_semi_long - new Vector3(0, 0, 0.00095f);
                  

                    box.transform.position = pos_adj;
                    size = 4;

                    flag_line = true;
                }
                else if (Input.GetKeyDown(KeyCode.Z))
                {
                    rane_straight.transform.position = hide;
                    rane_mid.transform.position = offset_mid;

                    pos_adj = pos_long - new Vector3(0, 0, 0.00105f);
                    box.transform.position = pos_adj;
                    size = 5;

                    flag_line = true;
                }
                else if (Input.GetKeyDown(KeyCode.P))
                {
                    rane_straight.transform.position = offset_str;
                    rane_mid.transform.position = hide;


                    box.transform.position = pos_mid;
                    size = 0;
                    flag_line = true;
                    flag_timer = true;
                }

                if(flag_line == false)
                {
                    line.transform.position = hide;
                }


              





                /*switch (rnd)
                {
                    case 0:
                        offset_kime.z = kime_st.z;

                        kime.transform.position = offset_kime;
                        break;
                    case 1:
                        offset_kime.z = offset_kime.z + 0.03f;

                        kime.transform.position = offset_kime;
                        break;

                    case 2:
                        offset_kime.z = offset_kime.z + 0.06f;
                        kime.transform.position = offset_kime;

                        break;
                    case 3:
                        offset_kime.z = offset_kime.z + 0.08f;
                        kime.transform.position = offset_kime;

                        break;
                }*/
            }

        }
        if (flag_line == false)
        {
            line.transform.position = hide;
        }
        if (flag_timer == true)
        {
            timer += Time.deltaTime;

            Debug.Log("time" + timer);
            if (timer >= interval)
            {
                rane_straight.transform.position = hide;
                rane_mid.transform.position = hide;
                box.transform.position = hide;
                kime.transform.position = hide;
                line.transform.position = hide;
                flag_line = false;
                timer = 0;
                flag_timer = false;
            }

        }
        else
        {
            timer = 0;
        }



        switch (size)
        {
            case 0:
                box.transform.localScale = box_size;
                break;
            case 1:
                /*box.transform.localScale = new Vector3(0.0944f, 0.0944f, 0.0944f);*/
                box.transform.localScale = new Vector3(0.0985f, 0.0985f, 0.0985f);
                break;
            case 2:
                box.transform.localScale = new Vector3(0.0984f, 0.0984f, 0.0984f);
                break;
            case 3:
                box.transform.localScale = new Vector3(0.0982f, 0.0982f, 0.0982f);
                break;
            case 4:
                box.transform.localScale = new Vector3(0.0981f, 0.0981f, 0.0981f);
                break;
            case 5:
                box.transform.localScale = new Vector3(0.0979f, 0.0979f, 0.0979f);
                break;

        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 dis;
            dis = box.transform.position - box.transform.localScale / 2;
            Debug.Log("position" + dis.z);
        }
       

    }
    /*void Cover()
    {
        timer += Time.deltaTime;
        wall.SetActive(false);
        hikari.SetActive(false);
        Debug.Log("time" + timer);
        if (timer > interval)
        {
            Debug.Log("fake");
            wall.SetActive(true);
            hikari.SetActive(true);
            timer = 0;
        }
    }*/
}
