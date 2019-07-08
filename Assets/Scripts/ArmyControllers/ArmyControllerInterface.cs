using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArmyControllerInterface : MonoBehaviour
{
    public int moveLength = 1;
    [HideInInspector]
    public bool madeChoice = false;

    public abstract void MakeChoice();

    public void MoveUp()
    {
        transform.Translate(Vector3.up * moveLength);
    }

    public void MoveDown()
    {
        transform.Translate(Vector3.down * moveLength);
    }

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * moveLength);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right * moveLength);
    }

}
