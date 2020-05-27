using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    public Image backImage;
    private bool isShown = false;
    private float trans = 0.0f;
    public float restartDelay;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive (false);
    }
    void Update() {
        trans += Time.deltaTime;
        backImage.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, trans);
    }

    public void ToggleDeathMenu()
    {
        gameObject.SetActive(true);
        isShown = true;
        Invoke("RestartGame",restartDelay);
    }

    public void RestartGame()
    {
        FadeOut();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void Exit()
    {
        SceneManager.LoadScene("menu");
    }
    //public void FadeIn()
    //{
    //    countText.canvasRenderer.SetAlpha(0.0f);
    //    countText.CrossFadeAlpha(1, 2, false);
    //}
    public void FadeOut()
    {
        backImage.canvasRenderer.SetAlpha(1.0f);
        backImage.CrossFadeAlpha(0, 2, true);

    }
    public void FadeIn()
    {
        backImage.canvasRenderer.SetAlpha(0.0f);
        backImage.CrossFadeAlpha(1, 2, false);
    }
}
