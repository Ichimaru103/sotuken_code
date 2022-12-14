using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size_change : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boxR;
    public GameObject sphereR;
    GameObject boxL;
    Vector3 size_boxR;
    Vector3 size_sphereR;
    Vector3 size_L;
    Vector3 st_sizebox;
    Vector3 st_sizesphere;
    void Start()
    {
       /* boxR = GameObject.FindGameObjectWithTag("boxR");*/
        boxL = GameObject.FindGameObjectWithTag("boxL");
        st_sizebox = boxR.transform.localScale;
        st_sizesphere = sphereR.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        size_boxR = boxR.transform.localScale;
        size_sphereR = sphereR.transform.localScale;
        size_L = boxL.transform.localScale;
        /*
                if (Input.GetKeyDown(KeyCode.S))
                {
                    size_boxR = st_sizebox;

                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                    size_sphereR = st_sizebox;

                }*/
        if (boxR.activeSelf)
        {

            sphereR.transform.localScale = st_sizebox;

        }
        if (sphereR.activeSelf)
        {
            boxR.transform.localScale = st_sizesphere;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
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

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SizedownL();
        }
    
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SizeupL();
        }

        
    }   
    
    void SizeupboxR()
    {
        size_boxR.x = size_boxR.x + 0.05f;
        size_boxR.y = size_boxR.y + 0.05f;
        size_boxR.z = size_boxR.z + 0.05f;
        boxR.transform.localScale = size_boxR;
        

    }
    void SizedownboxR()
    {
        size_boxR.x = size_boxR.x - 0.05f;
        size_boxR.y = size_boxR.y - 0.05f;
        size_boxR.z = size_boxR.z - 0.05f;
        boxR.transform.localScale = size_boxR;
       

    }
    void SizeupsphereR()
    {
        size_sphereR.x = size_sphereR.x + 0.05f;
        size_sphereR.y = size_sphereR.y + 0.05f;
        size_sphereR.z = size_sphereR.z + 0.05f;
        sphereR.transform.localScale = size_sphereR;
        
    }
    void SizedownsphereR()
    {
        size_sphereR.x = size_sphereR.x - 0.05f;
        size_sphereR.y = size_sphereR.y - 0.05f;
        size_sphereR.z = size_sphereR.z - 0.05f;
        sphereR.transform.localScale = size_sphereR;
        
    }
    void SizeupL()
    {
        size_L.x = size_L.x + 0.05f;
        size_L.y = size_L.y + 0.05f;
        size_L.z = size_L.z + 0.05f;
        boxL.transform.localScale = size_L;
    }
    void SizedownL()
    {
        size_L.x = size_L.x - 0.05f;
        size_L.y = size_L.y - 0.05f;
        size_L.z = size_L.z - 0.05f;
        boxL.transform.localScale = size_L;
    }
}
