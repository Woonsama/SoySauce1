using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageExtension : Image
{
    [Header("이미지 인식 범위 - 알파값 [0 ~ 1 (float)]")]
    public float alphaValue;

    private Image image;

    protected override void Awake()
    {
        base.Awake();

        image = GetComponent<Image>();
        image.alphaHitTestMinimumThreshold = alphaValue;
    }
}
