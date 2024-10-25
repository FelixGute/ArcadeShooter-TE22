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

    // TODO: Add callback
    // TODO: Add different kind of cards - ones that add a behavior, ones that alter stats, etc

    public void Selected()
    {
        Debug.Log("Selected " + cardName);
    }
}
