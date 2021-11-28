using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupItemManager : MonoBehaviour
{
    // PickupItemが生まれる数を取得するためにPickupItemSpawnerを参照する
    public PickupItemSpawner PickupItemSpawner;
    //　プレイヤーが取得したアイテム数
    public int PickupItemCount = 0;
    //　生まれた数
    public int PickupItemSpawnCount = 0;
    // 全て取得で来たかのフラグ
    public bool GetAllPickupItems = false;

    public GameState GameState;
    private void Start()

    {
        // PickupItemSpawneCountにPickupItemが生まれる数を代入する
        PickupItemSpawnCount = PickupItemSpawner.SpawnCount;

        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }
        //　当たった相手のtagがPickupItemだったら
        if (collision.gameObject.tag.Equals("PickupItem")) 
        {
            // PickupItemの値を1つ増やす(インクリメント）
            PickupItemCount++;
            // 生まれた数とPickupItemCountが同値になったらGetALLのフラグを立てる
            if (PickupItemCount == PickupItemSpawnCount)
            {
                GetAllPickupItems = true;
                GameState.SetGameProgressState(GameState.GameProgressStates.GameResult)
                    ;
            }
        }
    }   
}
