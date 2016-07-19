using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Handles the relationships between the player and the different entities in the game,
/// This gameobject will never get destroyed.
/// </summary>
public class GameController : MonoBehaviour
{
    public Dictionary<string, int> relationships = new Dictionary<string, int>();

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        relationships.Add("boss", 50);
        relationships.Add("dictator", 50);
        relationships.Add("citizens", 50);
    }

    void Update()
    {
        //Handle choices
        // if (choosesForCitizens) { relationships["boss"] -= 5; }
    }
}
