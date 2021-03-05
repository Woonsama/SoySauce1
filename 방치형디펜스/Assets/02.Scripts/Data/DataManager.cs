using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : SingletonMonoBase<DataManager>
{
    public GameData gameData = new GameData();

    public SettingData settingData = new SettingData();

    public AssetData assetData = new AssetData();

    protected override IEnumerator OnAwakeCoroutine()
    {
        DontDestroyOnLoad(this);
        return base.OnAwakeCoroutine();
    }
}

public class GameData
{
    private const int c_MaxWave = 100;

    public int currentSelectedWave;

    public bool[] isWaveCleared = new bool[c_MaxWave];

    public GameData()
    {
        currentSelectedWave = 0;
    }
}

public class SettingData
{
    public SettingData()
    {

    }
}

public class AssetData
{
    public enum EAssetType { Gold, Gem, None}

    public int iGold = 0;
    public int iGem = 0;

    public AssetData()
    {
        Do_LoadData();
    }

    public void Do_Add_Or_Minus_Asset(EAssetType eAssetType, int amount)
    {
        switch (eAssetType)
        {
            case EAssetType.Gold:
                iGold += amount;
                break;

            case EAssetType.Gem:
                iGem += amount;
                break;

            default:
                break;
        }
    }

    public void Do_Set_Asset(EAssetType eAssetType, int value)
    {
        switch (eAssetType)
        {
            case EAssetType.Gold:
                iGold = value;
                break;

            case EAssetType.Gem:
                iGem = value;
                break;

            default:
                break;
        }
    }

    public void Do_SaveData()
    {
        PlayerPrefs.SetInt("Gold", iGold);
        PlayerPrefs.SetInt("Gem", iGem);
    }

    public void Do_LoadData()
    {
        iGold = PlayerPrefs.GetInt("Gold");
        iGem = PlayerPrefs.GetInt("Gem");
    }
}
