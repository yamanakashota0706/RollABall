using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public SESoundManager SESoundManager;
    //　回転の速度
    public float Rollspeed = 0.2f;

    private void Update()
    {
        // (0,1,0)
        this.gameObject.transform.Rotate(Vector3.up * Rollspeed, Space.World);
    }

    // 衝突判定を取得します
    private void OnCollisionEnter(Collision collision)
    {
        //　もし衝突してきたのがPlayerだったら
        if (collision.gameObject.tag.Equals("Player"))
        {
            SESoundManager.PlayPickupItemSE();
            // 自分を消します
            Destroy(this.gameObject);
        }
    }
}

