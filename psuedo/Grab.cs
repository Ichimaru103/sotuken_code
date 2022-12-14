using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grab : MonoBehaviour
{
    [SerializeField] OVRHand MYRightHand;
    [SerializeField] OVRSkeleton MYRightSkelton;
    [SerializeField] GameObject IndexSphere;
    private bool isIndexPinching;
    private float ThumbPinchStrength;
    public GameObject real_hand;
    public GameObject fake_hand;
    public bool flagL = false;
    public bool flagR = false;
    public bool flag_st = false;
    void Start()
    {
        
    }
    void Update()
    {
       /* if (MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Index) != false)
        {
            isIndexPinching = MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Index);

            ThumbPinchStrength = MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb);

            Vector3 indexTipPos = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.position;
            Quaternion indexTipRotate = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.rotation;
            IndexSphere.transform.position = indexTipPos;
            IndexSphere.transform.rotation = indexTipRotate;
            Debug.Log("index ;" + MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Index));
            

        }*/
        isIndexPinching = MYRightHand.GetFingerIsPinching(OVRHand.HandFinger.Index);

        ThumbPinchStrength = MYRightHand.GetFingerPinchStrength(OVRHand.HandFinger.Thumb);

        Vector3 indexTipPos = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.position;
        Quaternion indexTipRotate = MYRightSkelton.Bones[(int)OVRSkeleton.BoneId.Hand_IndexTip].Transform.rotation;

        IndexSphere.transform.position = indexTipPos;
        IndexSphere.transform.rotation = indexTipRotate;




    }

    void OnTriggerEnter(Collider other)
    {
       /* Debug.Log(other.gameObject.tag);*/
        if(other.gameObject.tag == "boxL")
        {
            /*other.gameObject.SetActive(false);
            real_hand.gameObject.SetActive(false);
            fake_hand.gameObject.SetActive(true);*/
            flagL = true;
            flagR = false;
        }
        if (other.gameObject.tag == "boxR")
        {
            /*other.gameObject.SetActive(false);
            real_hand.gameObject.SetActive(false);
            fake_hand.gameObject.SetActive(true);*/
            flagR = true;
            flagL = false;
        }
        

    }

}