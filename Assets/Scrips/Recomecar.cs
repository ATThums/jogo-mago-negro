using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Recomecar : MonoBehaviour
{
    
    public GameObject gameOver;
    public GameObject telaJogo;
    public GameObject telaVitoria;
    public GameObject tudo;
    public GameObject telaIntro;
    public GameObject telaInicial;
    public GameObject telaSelecao;

    public string sceneToLoad;
    public string sceneToExit;
    public string sceneMenu;
    public string sceneFinal;

    public Text chances;
    
    
    public float releaseTime = 3.5f;
    public static int numberOfEnemies;
    public int enemies;
    public static int numberOfBall;
    public int balls;

    public static bool gameIsPause = false;
    public GameObject pauseMenuUI;

    public static bool canDamage = false;

    int levelPassed, sceneIndex;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        telaJogo.SetActive(true);
        gameOver.SetActive(false);
        telaVitoria.SetActive(false);
        tudo.SetActive(true);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void ExitScene()
    {
        SceneManager.LoadScene(sceneMenu);
        telaInicial.SetActive(true);
        telaIntro.SetActive(false);
        telaSelecao.SetActive(false);
    }

    void Start()
    {
        canDamage = false;
        Invoke("StartDamage", 2f);
        numberOfEnemies = enemies;
        numberOfBall = balls;
        Time.timeScale = 1f;
        sceneIndex = SceneManager.GetActiveScene().buildIndex; 
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    void StartDamage()
    {
        canDamage = true;
    }

    private void Update()
    {
        chances.text = numberOfBall.ToString();

        if (numberOfEnemies <= 0 || numberOfBall <= 0)
        {
            StartCoroutine(Release());
        }
                
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(sceneMenu);
        telaInicial.SetActive(false);
        telaIntro.SetActive(false);
        telaSelecao.SetActive(true);
    }

    public void IntroScene()
    {
        SceneManager.LoadScene(sceneMenu);
        StartCoroutine(MyTime());
        telaInicial.SetActive(false);
        telaIntro.SetActive(true);
        telaSelecao.SetActive(false);
    }

    private IEnumerator MyTime()
    {
        yield return new WaitForSeconds(0.5f);

    }

    IEnumerator Release()
    {
        
        yield return new WaitForSeconds(2f);

        if (numberOfEnemies <= 0 && numberOfBall >= 0)
        {
            yield return new WaitForSeconds(2f);

            SceneManager.LoadScene(sceneFinal);
        }

        yield return new WaitForSeconds(4f);


        if (numberOfEnemies <= 0 && numberOfBall >= 0)
        {
            gameOver.SetActive(false);
            telaVitoria.SetActive(true);
            telaJogo.SetActive(false);
            Time.timeScale = 0f;
            PlayerPrefs.SetInt("LevelPassed", SceneManager.GetActiveScene().buildIndex);
            //Unlocked.levelPassed++;
        }
                
        yield return new WaitForSeconds(7f);

        if (numberOfEnemies > 0 && numberOfBall <= 0)
        {
            gameOver.SetActive(true);
            telaVitoria.SetActive(false);
            telaJogo.SetActive(false);
            Time.timeScale = 0f;            
        }
    }  
    
}