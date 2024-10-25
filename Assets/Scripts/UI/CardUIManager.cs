using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CardUIManager : MonoBehaviour
{
    VisualElement cardContainer;

    private void Awake()
    {
        cardContainer = GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("CardContainer");
    }

    public void ShowCards()
    {
        CreateCard();
        CreateCard();
        CreateCard();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ShowCards();
        }
    }

    void CreateCard()
    {
        VisualElement card = new VisualElement();
        card.AddToClassList("card");

        Label heading = new Label();
        heading.AddToClassList("card__heading");
        heading.text = "";
        card.Add(heading);

        VisualElement icon = new VisualElement();
        icon.AddToClassList("card__icon");
        card.Add(icon);

        Label description = new Label();
        description.AddToClassList("description");
        description.text = "";
        card.Add(description);

        Button button = new Button();
        button.AddToClassList("card__button");
        button.text = "Choose";
        card.Add(button);

        cardContainer.Add(card);
    }
}
