using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MobState;
using Spine.Unity;

public class Mob_Enemy : Mob, IMove, IStop, IAttack, IRayDistance
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
        Move();
    }

    private void Update()
    {
        DrawRay();
        Behaviour();
    }

    public void Move()
    {
        eState = EState.Move;
        skeletonAnimation.AnimationName = "Move";
        skeletonAnimation.loop = true;
        transform.position += Vector3.left * stat.moveSpeed * Time.deltaTime;
    }

    public void Stop()
    {
        eState = EState.Idle;
        skeletonAnimation.AnimationName = "Idle";
        skeletonAnimation.loop = true;
    }

    public void Attack()
    {
        eState = EState.Attack;
        skeletonAnimation.AnimationName = "Attack";
        skeletonAnimation.loop = false;
    }

    RaycastHit2D hit;

    public void DrawRay()
    {
        //hit = Physics2D.Raycast(transform.position, Vector2.left, stat.recognizeDistance, LayerMask.NameToLayer("Mob"));

        hit = Physics2D.Raycast(transform.position, Vector2.left, stat.recognizeDistance);

        if (!hit) Debug.DrawLine(transform.position, (Vector2)transform.position + Vector2.left * stat.recognizeDistance, Color.green);
    }

    private void Behaviour()
    {
        if (hit.collider.tag == "Team")
        {
            Debug.Log("충돌체 : " + hit.collider.name);
            Stop();
        }
        else
        {
            Move();
        }
    }
}