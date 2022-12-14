using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_gen : MonoBehaviour
{
    public GameObject change;
    /*public bool flag_st;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
/*    void OnColllisionEnter(Collision collision)
    {
        color_change.instance.gen();
        Debug.Log(collision.gameObject.name);
        Debug.Log("“–‚½‚Á‚½‚º");
    }*/
        void OnTriggerEnter(Collider other)
    {
        /* color_change.instance.gen();*/
        change.GetComponent<color_change>().gen();
       /* Debug.Log(other.gameObject.name);
        Debug.Log("“–‚½‚Á‚½‚º");*/

    }
}
