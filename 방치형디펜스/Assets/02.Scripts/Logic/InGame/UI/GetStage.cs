using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStage : MonoBehaviour
{
    /*--------------------Const / Enum--------------------*/ 

    /*--------------------PublicMember--------------------*/

    /*--------------------Private / Protected Member--------------------*/

    /*--------------------Routine--------------------*/

    /*--------------------Public Function--------------------*/
    public string Do_GetStageString()
    {
        string str = "Stage " + DataManager.Instance.gameData.currentSelectedWave;
        return str;
    }

    /*--------------------Protected / Override--------------------*/

    /*--------------------Private Function--------------------*/

#region private

#endregion private

    /*--------------------Event Function--------------------*/

#region event

#endregion event
}