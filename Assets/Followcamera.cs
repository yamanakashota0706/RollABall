using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    // Follow����Target
    public GameObject FollowTarget;

    // Target �ƂȂ�ʒu�Ƃ̍�
    public Vector3 Offset;
        
    
   private void LateUpdate()
    {
        // �����̈ʒu��FOllow����Target�Ƃ̈ʒu�Ƃ̍���poaition�ɑ������
        transform.position = FollowTarget.transform.position + Offset;
        // �����̌�����Follow����Target�Ɍ����킹��
        transform.LookAt(FollowTarget.transform);
        
    }
}
