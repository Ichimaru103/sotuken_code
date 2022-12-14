using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_change : MonoBehaviour
{
    public GameObject box;
    public GameObject sphere;

    Vector3 st_pos;

    
    
    // Start is called before the first frame update
    void Start()
    {
        if(box.transform.position != null)
        {
            st_pos = box.transform.position;
        }
        if(sphere.transform.position != null)
        {
            st_pos = sphere.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
            Debug.Log("puss s");
            box.SetActive(false);
            sphere.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.B)){
            Debug.Log("puss b");
            box.SetActive(true);
            sphere.SetActive(false);
        }
    }
}
