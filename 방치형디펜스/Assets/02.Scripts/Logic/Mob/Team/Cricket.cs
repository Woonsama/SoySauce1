using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MobState;
using Spine.Unity;

public class Cricket : Mob, IMove, IStop, IAttack, IRayDistance
{
    public enum EState
    {
        Idle,
        Move,
        Attack,
        Die,
        Hit,
    }

    [Header("상태")]
    public EState eState;

    private SkeletonAnimation skeletonAnimation;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();

        eState = EState.Idle;
        skeletonAnimation.name = "Idle";
        skeletonAnimation.loop = true;
    }

    private void Update()
    {
        //DrawRay();
        Move();
    }

    public void Move()
    {
        eState = EState.Move;
        skeletonAnimation.name = "Move";
        skeletonAnimation.loop = true;
        transform.position += Vector3.right * stat.moveSpeed * Time.deltaTime;
    }

    public void Stop()
    {
        eState = EState.Idle;
        skeletonAnimation.name = "Idle";
        skeletonAnimation.loop = true;
    }

    public void Attack()
    {
        eState = EState.Attack;
        skeletonAnimation.name = "Attack";
        skeletonAnimation.loop = false;       
    }

    public void DrawRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * stat.recognizeDistance,0,LayerMask.NameToLayer("Enemy") | LayerMask.NameToLayer("EnemyTower"));

        Debug.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * stat.recognizeDistance, Color.green);

        Debug.Log("충돌 여부 판정 : " + hit.collider);

        if (hit)
        {
            Stop();
        }
        else
        {
            Move();
        }
    }
}