using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public SESoundManager SESoundManager;
    //�@��]�̑��x
    public float Rollspeed = 0.2f;

    private void Update()
    {
        // (0,1,0)
        this.gameObject.transform.Rotate(Vector3.up * Rollspeed, Space.World);
    }

    // �Փ˔�����擾���܂�
    private void OnCollisionEnter(Collision collision)
    {
        //�@�����Փ˂��Ă����̂�Player��������
        if (collision.gameObject.tag.Equals("Player"))
        {
            SESoundManager.PlayPickupItemSE();
            // �����������܂�
            Destroy(this.gameObject);
        }
    }
}

