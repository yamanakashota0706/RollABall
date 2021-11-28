using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    // FollowするTarget
    public GameObject FollowTarget;

    // Target となる位置との差
    public Vector3 Offset;
        
    
   private void LateUpdate()
    {
        // 自分の位置にFOllowするTargetとの位置との差をpoaitionに代入する
        transform.position = FollowTarget.transform.position + Offset;
        // 自分の向きをFollowするTargetに向かわせる
        transform.LookAt(FollowTarget.transform);
        
    }
}
