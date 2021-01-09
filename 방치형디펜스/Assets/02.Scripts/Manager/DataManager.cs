using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : SingletonMonoBase<DataManager>
{
    protected override IEnumerator OnAwakeCoroutine()
    {
        DontDestroyOnLoad(this);
        return base.OnAwakeCoroutine();
    }

}
