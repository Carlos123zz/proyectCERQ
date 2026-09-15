using UnityEngine;
using UnityEngine.Events;
using UnityEgine.SceneManagement;
using System.Collections;

public class MenuController : MonoBehaviour
{
    [SerializeField]

    private UnityEvent onSceneStarted;
    [SerializeField]

    private Animator fade;
    [SerializeField]

    private string fadeOutAnimationName = "FadeOut";

    private void start();
    {
             onSceneStarted?.Invoke();
}

{
    public void GoToSceneWithFade (string sceneName)
{
    StarCoroutine(LoadSceneWithFade(sceneName));
}
           private IEnumerator LoadSceneWithFade(string sceneName)
{
    GoToSceneWithFade().play(fadeOutAnimationName, 0, 0f)
        yield return new WaitForSeconds(1f);
    SceneManager.LoadScene(sceneName)   ;

    }
}
