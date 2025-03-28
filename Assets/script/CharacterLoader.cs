using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    private int[] selected = CharacterSelector.selected;
    [SerializeField]
    private GameObject[] characters;
    void Start()
    {
        if (selected[0] > 2 || selected[1] <3 || selected is null)
        {
            selected = new int[] { 0, 3 };
        }
        // Minden karaktert a külön tárolóba helyezünk
        foreach (var actual_character in characters)
        {
            actual_character.transform.position = new Vector2(0, -11);
        }

        // Ezután a selected character vissza kerül a helyére
        characters[selected[0]].transform.position = new Vector2(-6.5f, -1f);
        characters[selected[1]].transform.position = new Vector2(6.5f, -1f);

    }
}
