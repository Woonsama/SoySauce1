using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    [Header("현재 웨이브")]
    public EWave eWave;

    [Header("Enemy List")]
    [SerializeField] private GameObject[] enemys;

    [Header("Enemy Parent")]
    public Transform enemyParents;

    [Header("Enemy CreatePos")]
    public Transform enemyCreateTransform;

    private int enemyCount;

    private void Awake()
    {
        enemyCount = enemys.Length;

        StartCoroutine(StartPattern());

    }

    private IEnumerator StartPattern()
    {
        switch (eWave)
        {
            case EWave.WAVE1:
                Debug.Log("Wave1");
                StartCoroutine(CreateEnemy(0, 1));
                StartCoroutine(CreateEnemy(1, 2));
                StartCoroutine(CreateEnemy(2, 3));
                StartCoroutine(CreateEnemy(3, 4));
                StartCoroutine(CreateEnemy(4, 5));
                StartCoroutine(CreateEnemy(5, 6));
                StartCoroutine(CreateEnemy(6, 7));


                break;
            case EWave.WAVE2:
                break;
            case EWave.WAVE3:
                break;
            case EWave.WAVE4:
                break;
            case EWave.WAVE5:
                break;
            case EWave.WAVE6:
                break;
            case EWave.WAVE7:
                break;
            case EWave.WAVE8:
                break;
            case EWave.WAVE9:
                break;
            case EWave.WAVE10:
                break;
            default:
                break;
        }

        yield break;
    }


    private IEnumerator CreateEnemy(int index, float createTime)
    {
        yield return new WaitForSeconds(createTime);

        GameObject enemy = Instantiate(enemys[index], enemyCreateTransform.position, Quaternion.identity);
        enemy.transform.SetParent(enemyParents);
        enemy.name = "Enemy";
    }
}