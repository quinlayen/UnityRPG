using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : SingletonNetworkPersistent<SceneSwitcher>
{
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadRegisterNewUserScene()
    {
        SceneManager.LoadScene("Register");
    }
}
