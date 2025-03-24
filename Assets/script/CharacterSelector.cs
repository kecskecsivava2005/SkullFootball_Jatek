using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public Image player1Image;
    public Image player2Image;
    public Sprite[] characters;
    private int player1Index = 0;
    private int player2Index = 0;

    // Start is called before the first frame update
    void Start()
    {
        player1Index = PlayerPrefs.GetInt("Player1Character", 0);
        player2Index = PlayerPrefs.GetInt("Player2Character", 0);
        UpdateCharacters();
    }

    public void NextCharacter(int player)
    {
        if (player == 1)
        {
            player1Index = (player1Index + 1) % characters.Length;
        }
        else if (player == 2)
        {
            player2Index = (player2Index + 1) % characters.Length;
        }
        UpdateCharacters();
    }

    public void PrevCharacter(int player)
    {
        if (player == 1)
        {
            player1Index = (player1Index - 1 + characters.Length) % characters.Length;
        }
        else if (player == 2)
        {
            player2Index = (player2Index - 1 + characters.Length) % characters.Length;
        }
        UpdateCharacters();
    }

    void UpdateCharacters()
    {
        player1Image.sprite = characters[player1Index];
        player2Image.sprite = characters[player2Index];
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("Player1Character", player1Index);
        PlayerPrefs.SetInt("Player2Character", player2Index);
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
