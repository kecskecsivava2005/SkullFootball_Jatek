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
        if (selected[0] > characters.Length/2-1 || selected[1] < characters.Length/2 || selected is null)
        {
            selected = new int[] { 0, characters.Length/2 };
        }
        characters[selected[0]].transform.position = new Vector2(-6.5f, -1f);
        characters[selected[1]].transform.position = new Vector2(6.5f, -1f);

    }
}
