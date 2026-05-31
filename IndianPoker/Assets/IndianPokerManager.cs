using TMPro;
using UnityEngine;

public class IndianPokerManager : MonoBehaviour
{
    public enum GameState { init, Betting, Resolve, GameOver}
    public GameState currentState;

    private int playerCard;
    private int enemyCard;
    private int playerChips = 30;
    private int enemyChips = 30;
    private int currentBet = 0;

    public TextMeshProUGUI enemyCardText;
    public TextMeshProUGUI playerCardText;
    public TextMeshProUGUI logText;
    public TextMeshProUGUI chipsText;

    void Start()
    {
        
    }

    public void SetState(GameState nextState)
    {
        currentState = nextState;
        switch (currentState)
        {
            /*case GameState.init:
                StartNewRound();*/
           
        }
    }
}
