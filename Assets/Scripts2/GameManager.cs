using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("PlayerOne", 85);
        player2.InitializePlayer("PlayerTwo", 60);

        player1.Heal(10);          
        player2.Heal(true);        

        
        Player.ShowPlayerCount();
    }
}
