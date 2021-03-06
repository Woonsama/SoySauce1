using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    /*--------------------Const / Enum--------------------*/

    /*--------------------PublicMember--------------------*/

    /*--------------------Private / Protected Member--------------------*/

    /*--------------------Routine--------------------*/

    /*--------------------Public Function--------------------*/
    public string Do_GetCoinString()
    {
        return DataManager.Instance.assetData.iGold + "";
    }

    /*--------------------Protected / Override--------------------*/

    /*--------------------Private Function--------------------*/

#region private

#endregion private

    /*--------------------Event Function--------------------*/

#region event

#endregion event
}