using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

// effects with LeanTween 
public class mainMenu : MonoBehaviour
{
    public Button button;

    public float animCloseOpenDuration = 0.3f; // the duration of the opening and closing animation for the dialogue box.

    public void Start()
    {
        button.transform.LeanScale(Vector2.zero, 0f).setEaseInBack(); // hide by default, instantly (0f)
    }

    public void ShowButton()
    {
        button.transform.LeanScale(Vector2.one, animCloseOpenDuration);
    }

    public void CloseButton()
    {
        button.transform.LeanScale(Vector2.zero, animCloseOpenDuration).setEaseInBack();
    }
}