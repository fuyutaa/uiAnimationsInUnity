using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

// effects with LeanTween 
public class mainMenu : MonoBehaviour
{
    public string levelToLoad;

    public GameObject settingsWindow;
    public GameObject slidingButtons;

    public Button hideSlidingButtonsButton;
    public Button tapToStartButton;
    public Button settingsButton;
    // public Button devToolsButton;

    public Image Title;

    public Animator slidingButtonsAnimator;

    public static mainMenu instance;

    public void Start()
    {
        settingsWindow.transform.localScale = Vector2.zero;
        hideSlidingButtonsButton.transform.LeanScale(Vector2.zero, 0.3f).setEaseInBack();
        tapToStartButton.transform.LeanScale(Vector2.zero, 0.3f).setEaseInBack();
        settingsButton.transform.LeanScale(Vector2.zero, 0.3f).setEaseInBack();
        Title.transform.LeanScale(Vector2.zero, 0.3f).setEaseInBack();
        // devToolsButton.transform.LeanScale(Vector2.zero, 0.3f).setEaseInBack();
    }

    public void EnableUI()
    {
        tapToStartButton.transform.LeanScale(Vector2.one, 0f);
        settingsButton.transform.LeanScale(Vector2.one, 0f);
        Title.transform.LeanScale(Vector2.one, 0f);
        // devToolsButton.transform.LeanScale(Vector2.one, 0f);
    }

    public void TapToStart()
    {
        hideSlidingButtonsButton.transform.LeanScale(Vector2.one, 0f);
        slidingButtonsAnimator.SetBool("slide", true);

        tapToStartButton.transform.LeanScale(Vector2.zero, 0.3f).setEaseInOutBack();
    }

    public void hideSlidingButtons()
    {
        slidingButtonsAnimator.SetBool("slide", false);

        hideSlidingButtonsButton.transform.LeanScale(Vector2.zero, 0.3f).setEaseInBack();

        tapToStartButton.transform.LeanScale(Vector2.one, 0.1f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void SettingsButton()
    {
        settingsWindow.LeanScale(Vector2.one, 0.1f);
        // settingsWindow.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        settingsWindow.transform.LeanScale(Vector2.zero, 0.3f).setEaseInBack();
        // settingsWindow.SetActive(false);
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}