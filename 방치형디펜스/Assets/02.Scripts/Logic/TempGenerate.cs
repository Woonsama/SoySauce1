using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGenerate : ObjectBase
{
    [Header("Parent")]
    public Transform parent;

    [Header("GeneratePos")]
    public GameObject generate;


    [Header("Enemy")]
    public GameObject enemy;

    protected override IEnumerator OnAwakeCoroutine()
    {
        Invoke("CreateEnemy", 5);
        Invoke("CreateEnemy", 20);


        return base.OnAwakeCoroutine();
    }

    private void CreateEnemy()
    {
        Instantiate(enemy, generate.transform.position, Quaternion.identity, parent);
    }
}
