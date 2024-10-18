using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    VisualElement root;
    Button startButton;

    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        startButton = root.Q<Button>("button-start");
        startButton.RegisterCallback<ClickEvent>(OnStartButtonClicked);
    }

    private void OnDisable()
    {
        startButton.UnregisterCallback<ClickEvent>(OnStartButtonClicked);
    }

    void OnStartButtonClicked(ClickEvent evt)
    {
        print("Start button was clicked");
        SceneManager.LoadScene("FelixScene");
    }
}
