using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameUIManager : MonoBehaviour
{
    UIDocument UIDocument;
    VisualElement root;

    Label displayHealth;

    [SerializeField] Damageable playerHealth;

    Button button;

    private void Awake()
    {
        UIDocument = GetComponent<UIDocument>();
        root = UIDocument.rootVisualElement;

        displayHealth = root.Q("display-health") as Label;

        //displayHealth = root.Q<Label>("display-health");
    }

    private void Update()
    {
        displayHealth.text = playerHealth.health.ToString();
    }
}
