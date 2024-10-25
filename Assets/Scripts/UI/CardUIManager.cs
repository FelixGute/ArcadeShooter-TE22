using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CardUIManager : MonoBehaviour
{
    [SerializeField] List<Card> availableCards;
    VisualElement root;
    VisualElement cardContainer;

    private void Awake()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        cardContainer = root.Q<VisualElement>("CardContainer");
    }

    public void ShowCards()
    {
        cardContainer.Clear();
        CreateCard(availableCards[0]);
        CreateCard(availableCards[1]);
        CreateCard(availableCards[2]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ShowCards();
        }
    }

    void CreateCard(Card infoCard)
    {
        VisualElement card = new VisualElement();
        card.AddToClassList("card");

        Label heading = new Label();
        heading.AddToClassList("card__heading");
        heading.text = infoCard.cardName;
        card.Add(heading);

        VisualElement icon = new VisualElement();
        icon.AddToClassList("card__icon");
        //icon.style.backgroundImage = infoCard.icon;
        card.Add(icon);

        Label description = new Label();
        description.AddToClassList("description");
        description.text = infoCard.description;
        card.Add(description);

        Button button = new Button();
        button.AddToClassList("card__button");
        button.text = "Choose";
        // Registerar en callbackmetod som sedan kör OnCardSelected
        // Använder Lambdauttryck för att "hoppa över" kravet av en specifik typ av metod
        button.RegisterCallback<ClickEvent>(evnt => OnCardSelected(infoCard));
        card.Add(button);

        cardContainer.Add(card);
    }

    void OnCardSelected(Card card)
    {
        card.Selected();
        cardContainer.Clear();
    }
}
