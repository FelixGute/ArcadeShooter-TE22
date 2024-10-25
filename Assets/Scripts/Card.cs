using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName ="new card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public Sprite icon;
    public string description;

    public void SelectedPower(Event evnt)
    {
        Debug.Log("Selected " + cardName);
    }
}
