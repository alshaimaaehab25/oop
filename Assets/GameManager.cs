using UnityEngine;
public class GameManager : MonoBehaviour
{
    void Start()
    {
        
        Player ahmed = new Player();
        Player abod = new Player();

        
        ahmed.InitializePlayer("Playerahmed", 50);
        abod.InitializePlayer("Playerabod", 75);

        
        ahmed.Heal(20); 
        abod.Heal(true);

        
        Player.ShowPlayerCount();
    }
}