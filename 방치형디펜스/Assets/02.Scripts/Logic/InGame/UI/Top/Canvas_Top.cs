using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Top : CanvasBase
{
    /*--------------------Const / Enum--------------------*/

    /*--------------------PublicMember--------------------*/
    [Header("버튼 - 설정")]
    public Button button_setting;

    [Header("패널 - 세팅")]
    public GameObject panel_Setting;

    [Header("버튼 - 배속 설정")]
    public Button button_DoubleSpeed;

    [Header("배속")]
    public DoubleSpeed doubleSpeed;

    [Header("버프")]
    public Image image_Buff_1;
    public Image image_Buff_2;
    public Image image_Buff_3;
    public Image image_Buff_4;

    [Header("텍스트 - 스테이지 번호")]
    public Text text_stageNum;

    [Header("스테이지 번호")]
    public GetStage getStage;

    [Header("텍스트 - 코인")]
    public Text text_Coin;
    public GetCoin getCoin;

    [Header("텍스트 - 젬")]
    public Text text_Gem;
    public GetGem getGem;

    /*--------------------Private / Protected Member--------------------*/

    /*--------------------Routine--------------------*/

    protected override IEnumerator OnEnableCoroutine()
    {
        InitUI();
        return base.OnEnableCoroutine();
    }

    /*--------------------Public Function--------------------*/

    /*--------------------Protected / Override--------------------*/

    /*--------------------Private Function--------------------*/

    #region private

    private void InitUI()
    {
        button_setting.onClick?.AddListener(OnClick_Setting);
        button_DoubleSpeed.onClick?.AddListener(OnClick_DoubleSpeed);

        GetStage();
        GetCoin();
        GetGem();
    }

    private void OpenPanel_Setting()
    {
        panel_Setting.gameObject.SetActive(true);
    }

    #endregion private

    /*--------------------Event Function--------------------*/

    #region event

    private void OnClick_Setting()
    {
        OpenPanel_Setting();
    }

    private void OnClick_DoubleSpeed()
    {
        doubleSpeed.Do_ChangeType();
    }

    private void OnClick_Buff_Parent()
    {

    }

    /// <summary>
    /// GET - 스테이지 정보
    /// </summary>
    private void GetStage()
    {
        text_stageNum.text = getStage.Do_GetStageString();
    }

    /// <summary>
    /// GET - 코인 개수
    /// </summary>
    private void GetCoin()
    {
        text_Coin.text = getCoin.Do_GetCoinString();
    }

    /// <summary>
    /// GET -  젬 개수
    /// </summary>
    private void GetGem()
    {
        text_Gem.text = getGem.Do_GetGemString();
    }

    #endregion event
}