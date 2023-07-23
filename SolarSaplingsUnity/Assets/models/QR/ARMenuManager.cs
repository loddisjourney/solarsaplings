using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ARScene()
    {
        SceneManager.LoadScene("AR Game");
    }

    public void GameScene()
    {
        SceneManager.LoadScene("Game Menu");
    }

    public void StatsScene()
    {
        SceneManager.LoadScene("Stats Menu");
    }
}
