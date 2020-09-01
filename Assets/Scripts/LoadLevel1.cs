using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    public static LoadLevel1 instance;
    public Animator fadeAnim; //objeto que fará o fade para trocar de cena
    public int levelToLoad; //cena para carregar

    void Awake() {
        Debug.Log ("Olá");
        instance = this;
    }
    //pede o número da cena, executa a animação de fade e chama o void para carregar a cena
    public void FadeToLevel() {
        
        fadeAnim.SetTrigger("FadeIn");
        Invoke("LoadNewScene", 4.0f);
    }

    //carrega a nova cena
    public void LoadNewScene() {
        Debug.Log("Load New Scene");
        SceneManager.LoadSceneAsync(levelToLoad);
    }

    //sair do jogo
    public void QuitGame() {
        Application.Quit();
    }
}
