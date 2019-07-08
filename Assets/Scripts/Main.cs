using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main instance;
    int amountOfPlayers = 0;
    int playTurn = 0;
    int currentPlayer;

    [SerializeField]
    List<ArmyControllerInterface> armyControllers = new List<ArmyControllerInterface>();

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
            instance.enabled = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        amountOfPlayers = armyControllers.Count;
        
    }

    private void Update()
    {
        currentPlayer = playTurn % amountOfPlayers;

        armyControllers[currentPlayer].MakeChoice();
        if (armyControllers[currentPlayer].madeChoice)
        {
            playTurn++;
            armyControllers[currentPlayer].madeChoice = false;
            Debug.Log("Turn " + currentPlayer);
        }
        
    }


}
