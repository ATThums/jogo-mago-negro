using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllScenes : MonoBehaviour
{
    
    public string sceneToExit;
    public string scene1;
    public string scene2;
    public string scene3;
    public string scene4;
    public string scene5;
    public string scene6;
    public string scene7;
    public string scene8;
    public string scene9;
    public string scene10;
    public string scene11;
    public string scene12;
    public string scene13Final;

    public void ExitScene()
    {
        SceneManager.LoadScene(sceneToExit);
    }

    public void Scene1()
    {
        SceneManager.LoadScene(scene1);
    }

    public void Scene2()
    {
        SceneManager.LoadScene(scene2);
    }

    public void Scene3()
    {
        SceneManager.LoadScene(scene3);
    }

    public void Scene4()
    {
        SceneManager.LoadScene(scene4);
    }

    public void Scene5()
    {
        SceneManager.LoadScene(scene5);
    }

    public void Scene6()
    {
        SceneManager.LoadScene(scene6);
    }

    public void Scene7()
    {
        SceneManager.LoadScene(scene7);
    }

    public void Scene8()
    {
        SceneManager.LoadScene(scene8);
    }

    public void Scene9()
    {
        SceneManager.LoadScene(scene9);
    }

    public void Scene10()
    {
        SceneManager.LoadScene(scene10);
    }

    public void Scene11()
    {
        SceneManager.LoadScene(scene11);
    }

    public void Scene12()
    {
        SceneManager.LoadScene(scene12);
    }

    public void Scene13Final()
    {
        SceneManager.LoadScene(scene13Final);
    }
}
