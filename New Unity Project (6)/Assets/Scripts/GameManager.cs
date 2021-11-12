using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int enemyKilled = 0;
    public Door Door;

    public void UpdateScore()
    {
        enemyKilled++;
        if(enemyKilled == 5)
        {
            Door.Doorlock();
        }
    }

    public void OnGUI()
    {
        GUI.contentColor = Color.yellow;
        GUI.Box(new Rect(5, 5, 20, 20), "Enemies killed: " + enemyKilled);
    }

}
