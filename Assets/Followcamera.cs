using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    // Follow‚·‚éTarget
    public GameObject FollowTarget;

    // Target ‚Æ‚È‚éˆÊ’u‚Æ‚Ì·
    public Vector3 Offset;
        
    
   private void LateUpdate()
    {
        // ©•ª‚ÌˆÊ’u‚ÉFOllow‚·‚éTarget‚Æ‚ÌˆÊ’u‚Æ‚Ì·‚ğpoaition‚É‘ã“ü‚·‚é
        transform.position = FollowTarget.transform.position + Offset;
        // ©•ª‚ÌŒü‚«‚ğFollow‚·‚éTarget‚ÉŒü‚©‚í‚¹‚é
        transform.LookAt(FollowTarget.transform);
        
    }
}
