using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class MonsterData
{
    public string nameKr;
    public string nameEn;
    public int hp;
    public int attackPower;
    public float speed;
    public float attackDelay;

    public MonsterData(string nameKr, string nameEn, int hp, int attackPower, float speed, float attackDelay)
    {
        this.nameKr = nameKr;
        this.nameEn = nameEn;
        this.hp = hp;
        this.attackPower = attackPower;
        this.speed = speed;
        this.attackDelay = attackDelay;
    }
}