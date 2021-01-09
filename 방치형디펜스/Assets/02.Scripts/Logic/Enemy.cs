using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : ObjectBase
{
    public enum EState
    {
        Idle,
        Move,
        Attack,
        Hitted,
        Die,
    }

    [Header("체력")]
    [SerializeField] protected int hp;

    [Header("공격력")]
    [SerializeField] protected int attackPower;

    [Header("공격 딜레이")]
    [SerializeField] protected int attackDelay;

    [Header("이동속도")]
    [SerializeField] protected int moveSpeed;

    protected EState eState;
    protected bool isDie;
    protected Rigidbody2D rigid;
    protected BoxCollider2D boxCollider;

    protected override IEnumerator OnAwakeCoroutine()
    {
        isDie = false;
        rigid = gameObject.AddComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
        boxCollider = gameObject.AddComponent<BoxCollider2D>();

        return base.OnAwakeCoroutine();
    }
}
