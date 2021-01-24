using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonExtention : Button
{
    private Button button;

    //버튼 클릭 시에 이벤트 함수 추가용
    public UnityAction action;

    protected override void Awake()
    {
        base.Awake();

        button = GetComponent<Button>();
        button.onClick?.AddListener(action);
    }
}