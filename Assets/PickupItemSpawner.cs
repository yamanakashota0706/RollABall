using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemSpawner : MonoBehaviour
{
    // ��������PickupItem
    public GameObject PickupItem;
    // ���������
    public int SpawnCount = 0;
    //�@��������~�̔��a
    //public float SpawnCircleRadius = 3f;
    public List<Transform> SpawnPositions = new List<Transform>();

    public SESoundManager SESoundManager;

    // Start is called before the first frame update
    void Awake()
    {
        //�@�~����SpawnCount�Ŋ������p�x
        //float radian = Mathf.PI * 2 / SpawnCount;
        for (int i = 0; i < SpawnPositions.Count; i++)
        {
            GameObject Pick = Instantiate(PickupItem);

            Pick.GetComponent<PickupItem>().SESoundManager = SESoundManager;

            Pick.transform.position = SpawnPositions[i].position;
            SpawnCount++;
        }
            // �V����Vector3���쐬���A��������PickupItme��Position����
            //Vector3 pos = Pick.transform.position;
            // Pos��z�̒l�ɉ~����y�̒l��SpawnCircleRadius�Ŋ|�����l����
            //pos.z = Mathf.Sin(radian * (i + 1)) * SpawnCircleRadius;
            // Pos�̂��̒l�ɉ~���̂��̒l��SpawnCircleRadius�Ŋ|�����l����
            //pos.x = Mathf.Cos(radian * (i + 1)) * SpawnCircleRadius;
            // ���߂�ꂽVector3�𐶐����ꂽPick��position�ɑ��
            //Pick.transform.position = pos;
         //}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
