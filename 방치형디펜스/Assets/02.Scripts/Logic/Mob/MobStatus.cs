using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class MobStatus
{
    public int hp; //체력
    public float moveSpeed; //이동속도
    public int attackPower; //공격력
    public float attackDelay; //공격속도
    public float recognizeDistance; //몹 인식범위
    public int coin; // 사망 시 얻는 코인 개수 
}