using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bee : Enemy
{
    protected override IEnumerator OnAwakeCoroutine()
    {
        yield return StartCoroutine(Update_Coroutine());
    }

    private IEnumerator Update_Coroutine()
    {
        while(!isDie)
        {
            yield return StartCoroutine(Behaviour());
        }
    }

    private IEnumerator Behaviour()
    {
        StartCoroutine(Move());

        yield break;
    }

    private IEnumerator Move()
    {
        transform.position -= Vector3.right * moveSpeed * Time.deltaTime;
        yield break;
    }
}
