using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public GameObject Inner;
    public Vector2 Position;
    public bool Coloreado = false;
    private void OnMouseDown()
    {
        if (!Coloreado)
        {
            Debug.Log("Mouse Down");
            if (GameManager.Instance.GetGameState == GameManager.GameState.player1)
            {
                Inner.GetComponent<SpriteRenderer>().color = Color.blue;
            }else
            {
                Inner.GetComponent<SpriteRenderer>().color = Color.red;
            }
            Coloreado = true;
            BoardManager.Instance.SetLine(this);
        }
    }
}
