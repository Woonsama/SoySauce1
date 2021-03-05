using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGem : MonoBehaviour
{
    /*--------------------Const / Enum--------------------*/

    /*--------------------PublicMember--------------------*/

    /*--------------------Private / Protected Member--------------------*/

    /*--------------------Routine--------------------*/

    /*--------------------Public Function--------------------*/
    public string Do_GetGemString()
    {
        return DataManager.Instance.assetData.iGem + "";
    }

    /*--------------------Protected / Override--------------------*/

    /*--------------------Private Function--------------------*/

    #region private

    #endregion private

    /*--------------------Event Function--------------------*/

    #region event

    #endregion event
}