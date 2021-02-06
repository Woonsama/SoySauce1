using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSlot : ActiveBase
{
    private const int c_MobCount = 7;

    [Header("Parent - Mob")]
    public Transform mobParent;

    [Header("GeneratePos")]
    public Transform generateTransform;

    [Header("Mob")]
    public GameObject[] mobs = new GameObject[c_MobCount];

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) GenerateMob(Random.Range(0,c_MobCount));
    }


    private void GenerateMob(int index)
    {
        GameObject mob = Instantiate(mobs[index], generateTransform.position, Quaternion.identity);
        mob.transform.SetParent(generateTransform);
        mob.name = "Mob";
    }
}