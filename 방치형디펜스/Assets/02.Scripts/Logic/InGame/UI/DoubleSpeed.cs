using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleSpeed : MonoBehaviour
{
    /*--------------------Const / Enum--------------------*/
    public enum ESpeedType
    {
        X_ONE = 0,
        X_ONE_POINT_FIVE = 1,
        X_TWO = 2,

        Length = X_TWO + 1,
    }

    /*--------------------PublicMember--------------------*/
    [Header("배속")]
    public ESpeedType eSpeedType;

    [Header("배속 별 이미지")]
    public Sprite[] sprite_Image_DoubleSpeed = new Sprite[(int)ESpeedType.Length];

    [Header("이미지")]
    public Image image;

    private Dictionary<ESpeedType, float> map_DoubleSpeed = new Dictionary<ESpeedType, float>();

    /*--------------------Private / Protected Member--------------------*/

    private void Awake()
    {
        Init();
    }

    /*--------------------Routine--------------------*/

    /*--------------------Public Function--------------------*/
    public void Do_SetSpeedType(ESpeedType eSpeedType)
    {
        this.eSpeedType = eSpeedType;
    }

    public void Do_SetImage(ESpeedType eSpeedType)
    {
        image.sprite = sprite_Image_DoubleSpeed[(int)eSpeedType];
    }

    public void Do_ChangeType()
    {
        eSpeedType = (ESpeedType)(((int)eSpeedType + 1) % (int)ESpeedType.Length);
        Do_SetImage(eSpeedType);
        SetTimeScale(map_DoubleSpeed[eSpeedType]);
    }

    /*--------------------Protected / Override--------------------*/

    /*--------------------Private Function--------------------*/

    #region private

    private void Init()
    {
        map_DoubleSpeed.Add(ESpeedType.X_ONE, 1.0f);
        map_DoubleSpeed.Add(ESpeedType.X_ONE_POINT_FIVE, 1.5f);
        map_DoubleSpeed.Add(ESpeedType.X_TWO, 2.0f);

        Do_SetSpeedType(ESpeedType.X_ONE);
        Do_SetImage(ESpeedType.X_ONE);
    }

    private void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    #endregion private

    /*--------------------Event Function--------------------*/

    #region event

    #endregion event
}