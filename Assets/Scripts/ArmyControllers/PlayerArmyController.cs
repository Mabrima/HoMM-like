using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmyController : ArmyControllerInterface
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public override void MakeChoice()
    {
        CheckKeys();
    }

    void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveUp();
            madeChoice = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveDown();
            madeChoice = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
            madeChoice = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
            madeChoice = true;
        }
    }


}
