using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand_tracking : MonoBehaviour
{
    public GameObject real_hand;
    public GameObject fake_hand;
    public GameObject sphere;
    public float rateR;
    public float rateL;

   /* Quaternion move_hand;*/
    Vector3 st_posL;
    Vector3 st_posR;
    Vector3 real_pos;
    Vector3 fake_pos;
    bool flag_stL = true;
    bool flag_stR = true;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       
        real_pos = real_hand.transform.position;
        fake_pos = real_hand.transform.position;
        /* fake_pos.x = real_pos.x * rate;*/

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Debug.Log("0‚ð‰Ÿ‚µ‚½");
            rateR = rateR - 0.10f;
            if(rateR < 1)
            {
                rateR = rateR * 10;
                rateR = Mathf.Ceil(rateR);
                rateR = rateR / 10;
            }
            if(rateR < 0.5f)
            {
                rateR = 0.5f;
            }
            Debug.Log("rateR" + rateR);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            Debug.Log("1‚ð‰Ÿ‚µ‚½");
            rateR = rateR + 0.1f;
            if (rateR < 1)
            {
                rateR = rateR * 10;
                rateR = Mathf.Ceil(rateR);
                rateR = rateR / 10;
            }
            Debug.Log("rateR" + rateR);
        }

        if (sphere.GetComponent<Grab>().flagL)
        {
            
            /*fake_pos.z = real_pos.z * rate;*/
            SetposL();

           /* Debug.Log("kieta");*/
        }
        if (sphere.GetComponent<Grab>().flagR)
        {

            /*fake_pos.z = real_pos.z * rate;*/
            SetposR();

            /* Debug.Log("kieta");*/
        }

        /*  fake_hand.transform.rotation = real_hand.transform.rotation;*/

        /* float dis = Vector3.Distance(real_hand.transform.position, fake_hand.transform.position);*/

        /*  Debug.Log("dis :" + dis);*/
        /*if (rate > 1)
        {
            float temp;
            temp = 1 - (1 - rate);
            fake_pos.y = real_pos.y * temp;
            fake_pos.z = real_pos.z * temp;
        }
        else if (rate < 1)
        {
            float temp;
            temp = 1 + (1 - rate);
            fake_pos.y = real_pos.y * temp;
            fake_pos.z = real_pos.z * temp;
        }
        else
        {
            float temp = 1;
            fake_pos.y = real_pos.y * temp;
            fake_pos.z = real_pos.z * temp;
        }*/

        fake_hand.transform.position = fake_pos;
    }
    void SetposL()
    {
        Vector3 dis;

        /*Vector3 temp;*/
       /* float a;*/
        if(flag_stL == true)
        {
            st_posL = real_pos;
            flag_stL = false;
        }
        dis = real_pos - st_posL;
        /*temp = real_pos * rateL;*/
        if(dis.z > 0)
        {
            fake_pos.z = st_posL.z + dis.z * rateL;
            Debug.Log("rate " + rateL);
        }
        else
        {
            fake_pos.z = real_pos.z;
        }
        

        /*a = fake_pos.z - temp.z;*/


      
        /*  Debug.Log("st; " + st_pos);
          Debug.Log("real; " + real_pos);*/
        /*Debug.Log("fake;" + fake_pos.z);*/
        /*Debug.Log("temp ;" + temp.z);
        Debug.Log("aiueo;" + a);*/
        /*Debug.Log("dis; " + dis);*/

    }
    void SetposR()
    {
        Vector3 dis;
       /* Vector3 temp;*/
        /*float a;*/
        if (flag_stR == true)
        {
            st_posR = real_pos;
            flag_stR = false;
        }
        dis = real_pos - st_posR;
        /* temp = real_pos * rateR;*/
        if (dis.z > 0)
        {
            fake_pos.z = st_posR.z + dis.z * rateR;
            Debug.Log("rateR " + rateR);
        }
        else
        {
            fake_pos.z = real_pos.z;
        }

        /* a = fake_pos.z - temp.z;*/


        



        /*  Debug.Log("st; " + st_pos);
          Debug.Log("real; " + real_pos);*/
        /*Debug.Log("fake;" + fake_pos.z);*/
        /* Debug.Log("temp ;" + temp.z);
         Debug.Log("aiueo;" + a);*/
        /*Debug.Log("dis; " + dis);*/

    }

}
