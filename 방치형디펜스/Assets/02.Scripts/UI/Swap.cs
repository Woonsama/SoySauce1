using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Swap : CanvasBase
{
    private const float c_SwapSpeed = 0.3f;

    [Header("Swap Target")]
    [SerializeField] private GameObject swapTarget1 = null;
    [SerializeField] private GameObject swapTarget2 = null;

    [Header("Button - Swap")]
    public Button buttonSwap;

    private bool isFront = true;

    private bool isSwapEndTarget1 = true;
    private bool isSwapEndTarget2 = true;


    protected override IEnumerator OnEnableCoroutine()
    {
        buttonSwap.onClick?.AddListener(DoSwap);
        return base.OnEnableCoroutine();
    }

    private void DoSwap()
    {
        if(isSwapEndTarget1 == true && isSwapEndTarget2 == true)
        {
            isSwapEndTarget1 = isSwapEndTarget2 = false;

            Vector3 tempPos;

            if (isFront)
            {
                tempPos = swapTarget1.transform.position;
                swapTarget1.transform.DOMove(swapTarget2.transform.position, c_SwapSpeed).OnComplete(() => { isSwapEndTarget1 = true; });
                swapTarget2.transform.DOMove(tempPos, c_SwapSpeed).OnComplete(() => { isSwapEndTarget2 = true; });
                swapTarget2.transform.SetAsFirstSibling();
            }
            else
            {
                tempPos = swapTarget2.transform.position;
                swapTarget2.transform.DOMove(swapTarget1.transform.position, c_SwapSpeed).OnComplete(() => { isSwapEndTarget2 = true; }); ;
                swapTarget1.transform.DOMove(tempPos, c_SwapSpeed).OnComplete(() => { isSwapEndTarget1 = true; }); ;
                swapTarget1.transform.SetAsFirstSibling();
            }

            isFront = !isFront;
        }
    }

}
