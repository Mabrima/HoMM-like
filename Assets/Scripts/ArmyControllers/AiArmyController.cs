using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiArmyController : ArmyControllerInterface
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void MakeChoice()
    {
        int choice = Random.Range(0, 4);

        switch (choice)
        {
            case 0:
                MoveUp();
                madeChoice = true;
                break;
            case 1:
                MoveDown();
                madeChoice = true;
                break;
            case 2:
                MoveLeft();
                madeChoice = true;
                break;
            case 3:
                MoveRight();
                madeChoice = true;
                break;
            default:
                break;
        }

    }

    
}