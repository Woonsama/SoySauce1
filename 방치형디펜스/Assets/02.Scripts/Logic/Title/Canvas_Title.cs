using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Canvas_Title : CanvasBase
{
    /*--------------------Const / Enum--------------------*/

    /*--------------------PublicMember--------------------*/
    [Header("Text - Title Sample")]
    public Text text_Title_Sample;

    [Header("Fade 시간")]
    public float fadeTime;

    /*--------------------Private / Protected Member--------------------*/
    protected override IEnumerator OnEnableCoroutine()
    {
        Init();
        return base.OnEnableCoroutine();
    }

    /*--------------------Routine--------------------*/

    /*--------------------Public Function--------------------*/

    /*--------------------Protected / Override--------------------*/

    /*--------------------Private Function--------------------*/

    #region private

    private void Init()
    {
        StartCoroutine(Do_Fade());
    }

    private IEnumerator Do_Fade()
    {
        SetAlpha(0);
        yield return StartCoroutine(Do_FadeIn());
        yield return new WaitForSeconds(2.0f);
        yield return StartCoroutine(Do_FadeOut());
        SetAlpha(1);
        yield return new WaitForSeconds(1.0f);
        GoToInGame();
    }

    private IEnumerator Do_FadeIn()
    {
        float currentTime = 0;

        while(currentTime <= fadeTime)
        {
            currentTime += Time.deltaTime;
            SetAlpha(1 / (fadeTime / currentTime));
            yield return null;
        }
    }

    private IEnumerator Do_FadeOut()
    {
        float currentTime = 0;

        while (currentTime <= fadeTime)
        {
            currentTime += Time.deltaTime;
            SetAlpha(1 - (1 / (fadeTime / currentTime)));
            yield return null;
        }
    }

    private void SetAlpha(float alpha)
    {
        Color textColor = text_Title_Sample.color;
        text_Title_Sample.color = new Color(textColor.r, textColor.g, textColor.b, alpha);
    }

    private void GoToInGame()
    {
        SceneManager.LoadScene("KWS");
    }

    #endregion private

    /*--------------------Event Function--------------------*/

    #region event

    #endregion event
}