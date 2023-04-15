using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]

public class LivesCountField : MonoBehaviour
{
    private int lives = 3;

    public int GetLives()
    {
        return this.lives;
    }

    public void ResetLives()
    {
        this.lives = 3;
        this.updateLives();
    }

    public void DropLive()
    {
        this.lives--;
        this.updateLives();
    }

    public void updateLives()
    {
        GetComponent<TextMeshPro>().text = "lives: " + this.lives.ToString();
    }
}
