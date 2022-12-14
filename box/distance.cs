using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    public GameObject boxR;
    public GameObject boxL;
    public GameObject sphereR;
    public GameObject pole;
    Vector3 st_posR;
    Vector3 st_posL;
    Vector3 posR;
    Vector3 posL;
    float dis;
    float tempL;
    float tempR;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        st_posR = boxR.transform.position;
        st_posL = boxL.transform.position;
         tempL = 0;
         tempR = 0;

    }

    // Update is called once per frame
    void Update()
    {
 
        
 

        posR = boxR.transform.position;
        posL = boxL.transform.position;

        if (i > 200)
        {
            Debug.Log("’lŠ®—¹");
            tempR = posR.z;
            tempL = posL.z;
            
            i = 0;
        }
        if (tempR == posR.z && tempL == posL.z)
        {
            Debug.Log("Rbox" + posR.z);
            Debug.Log("Lbox" + posL.z);
            dis = posR.z - posL.z;
            Debug.Log("dis R-L" + dis);
            pole.GetComponent<Renderer>().material.color = Color.blue;

        }
        else
        {
            pole.GetComponent<Renderer>().material.color = Color.white;
        }
        i++;

/*        Debug.Log("Rbox" + posR.z);
        Debug.Log("Lbox" + posL.z);
        dis = posR.z - posL.z;
        Debug.Log("dis R-L" +dis);*/
        
    }
}
