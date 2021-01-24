using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public enum EDirection { Left, Right};

    [Header("생성 포지션")]
    public Transform enemyParent;

    public GameObject[] enemy;

    [Header("생성 주기")]
    public float generateDelay;

    [Header("방향")]
    public EDirection eDirection;

    private void Awake()
    {
        StartCoroutine(Generate_Coroutine());
    }

    //Test
    private IEnumerator Generate_Coroutine()
    {
        //while(true)
        {
            yield return new WaitForSeconds(generateDelay);

            int randomValue = Random.Range(0, enemy.Length);

            GameObject enemyTemp = Instantiate(enemy[randomValue], enemyParent.position, Quaternion.identity);

            Mob mob = enemyTemp.GetComponent<Mob>();

            if(eDirection == EDirection.Left){

            }else if(eDirection == EDirection.Right){

            }

        }
    }


}