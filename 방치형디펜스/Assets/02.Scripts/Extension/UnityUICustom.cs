using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UI;


public static class UnityUICustom
{
    [MenuItem("GameObject/UI/ImageExtension")]

    public static void AddImageExtension()
    {
        var obj = new GameObject("ImageExtension");
        obj.transform.localPosition = Vector3.zero;

        obj.AddComponent<RectTransform>();
        obj.AddComponent<ImageExtension>();
    }

    [MenuItem("GameObject/UI/ButtonExtension")]

    public static void AddButtonExtension()
    {
        var obj = new GameObject("ButtonExtension");
        obj.transform.localPosition = Vector3.zero;

        obj.AddComponent<RectTransform>();
        obj.AddComponent<ImageExtension>();
        obj.AddComponent<ButtonExtention>();

    }
}