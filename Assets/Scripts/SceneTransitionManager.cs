using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    //public FaderScreen fadeScreen;
    // Start is called before the first frame update
    public void GoToScene(int sceneIndex)
    {
        //StartCoroutine(GoToSceneRoutine(sceneIndex));
        SceneManager.LoadScene(sceneIndex);
    }
/*
    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        SceneManager.LoadScene(sceneIndex);
    }
*/
}
