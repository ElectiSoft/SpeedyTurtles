using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private int cardType;
    [SerializeField] private int cardColor;
    [SerializeField] private SpriteRenderer typeHolder;
    [SerializeField] private SpriteRenderer colorHolder;
    [SerializeField] private List<Sprite> types;
    [SerializeField] private List<Sprite> colors;

    void Update()
    {
        typeHolder.sprite = types[cardType];
        colorHolder.sprite = colors[cardColor];   
    }
}
