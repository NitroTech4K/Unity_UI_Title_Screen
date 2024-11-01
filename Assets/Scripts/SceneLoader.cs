using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void QuitGame()
    {
        StartCoroutine(QuitAfterDelay());
    }

    IEnumerator QuitAfterDelay()
    {
        // Wait for 1 second
        yield return new WaitForSeconds(1f);

        // Quit the application
        Application.Quit();
    }
}
