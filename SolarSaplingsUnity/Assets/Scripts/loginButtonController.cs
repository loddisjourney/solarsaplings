using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loginButtonController : MonoBehaviour
{
    public string SceneName;
    public void ButtonPressed()
    {
        Scene thisMenu = SceneManager.GetActiveScene();

        SceneManager.LoadSceneAsync(SceneName);
        //SceneManager.UnloadSceneAsync(thisMenu);
    }
}
