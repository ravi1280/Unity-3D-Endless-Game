using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject[] characterPrefabs; // assign in inspector
    public Transform spawnPoint; // where to place the character

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0); // default to 0
        GameObject clone = Instantiate(characterPrefabs[selectedCharacter], spawnPoint.position, spawnPoint.rotation);
    }
}




