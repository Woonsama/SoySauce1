using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Setting : CanvasBase
{
    /*--------------------Const / Enum--------------------*/
    const float initial_FillAmount = 0.5f;

    /*--------------------PublicMember--------------------*/
    [Header("버튼 - 종료")]
    public Button button_Exit;

    [Header("패널 - 세팅")]
    public GameObject panel_Setting;

    [Header("배경음 수치")]
    public Image fill_Bgm;

    [Header("효과음 수치")]
    public Image fill_SE;

    [Header("구글 로그인")]
    public Button button_GoogleLogin;

    [Header("크레딧")]
    public Button button_Credit;

    /*--------------------Private / Protected Member--------------------*/

    protected override IEnumerator OnEnableCoroutine()
    {
        Init();
        InitFill();
        return base.OnEnableCoroutine();
    }

    /*--------------------Routine--------------------*/

    /*--------------------Public Function--------------------*/

    /*--------------------Protected / Override--------------------*/

    /*--------------------Private Function--------------------*/

    #region private

    private void Init()
    {
        button_Exit.onClick?.AddListener(OnClick_Exit);
        button_GoogleLogin.onClick?.AddListener(OnClick_GoogleLogin);
        button_Credit.onClick?.AddListener(OnClick_Credit);
        InitFill();
    }

    private void InitFill()
    {
        fill_Bgm.fillAmount = fill_SE.fillAmount = initial_FillAmount;
    }
    #endregion private

    /*--------------------Event Function--------------------*/

    #region event

    private void OnClick_Exit()
    {
        CloseSetting();
    }

    private void CloseSetting()
    {
        panel_Setting.gameObject.SetActive(false);
    }

    private void OnClick_GoogleLogin()
    {

    }

    private void OnClick_Credit()
    {

    }

    #endregion event
}