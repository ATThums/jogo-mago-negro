using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Unlocked : MonoBehaviour
{
    public Button level2Button, level3Button, level4Button, level5Button, level6Button, level7Button, level8Button, level9Button, level10Button, level11Button, level12Button, level13Button;
    //int levelPassed;
    public Scene scene1;
    private int levelPassed = 0;
    public string sceneToExit;

    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level2Button.interactable = false;
        level3Button.interactable = false;
        level4Button.interactable = false;
        level5Button.interactable = false;
        level6Button.interactable = false;
        level7Button.interactable = false;
        level8Button.interactable = false;
        level9Button.interactable = false;
        level10Button.interactable = false;
        level11Button.interactable = false;
        level12Button.interactable = false;
        level13Button.interactable = false;


        switch (levelPassed)
        {
            case 1:
                level2Button.interactable = true;
                break;
            case 2:
                level2Button.interactable = true;
                level3Button.interactable = true;
                break;
            case 3:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                break;
            case 4:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                break;
            case 5:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                break;
            case 6:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                level7Button.interactable = true;
                break;
            case 7:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                level7Button.interactable = true;
                level8Button.interactable = true;
                break;
            case 8:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                level7Button.interactable = true;
                level8Button.interactable = true;
                level9Button.interactable = true;
                break;
            case 9:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                level7Button.interactable = true;
                level8Button.interactable = true;
                level9Button.interactable = true;
                level10Button.interactable = true;
                break;
            case 10:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                level7Button.interactable = true;
                level8Button.interactable = true;
                level9Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                break;
            case 11:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                level7Button.interactable = true;
                level8Button.interactable = true;
                level9Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                break;
            case 12:
                level2Button.interactable = true;
                level3Button.interactable = true;
                level4Button.interactable = true;
                level5Button.interactable = true;
                level6Button.interactable = true;
                level7Button.interactable = true;
                level8Button.interactable = true;
                level9Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                break;
        }
    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene (level);
    }

    private void OnEnable()
    {
        PlayerPrefs.SetInt("levelPassed", levelPassed);

    }

    public void resetPlayerPrefs()
    {
        level2Button.interactable = false;
        level3Button.interactable = false;
        level4Button.interactable = false;
        level5Button.interactable = false;
        level6Button.interactable = false;
        level7Button.interactable = false;
        level8Button.interactable = false;
        level9Button.interactable = false;
        level10Button.interactable = false;
        level11Button.interactable = false;
        level12Button.interactable = false;
        level13Button.interactable = false;
        PlayerPrefs.DeleteAll ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitScene()
    {
        SceneManager.LoadScene(sceneToExit);
    }
}
