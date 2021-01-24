using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("체력")]
    [SerializeField] private int hp;

    public void GetDamage(int hp)
    {
        this.hp -= hp;

        if (hp < 0) hp = 0;
    }
}