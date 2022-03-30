using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Line[] LinesSquare;
    public Vector2 Position;

    void Start()
    {
        LinesSquare = new Line[4];
        Position = this.GetComponent<Transform>().position;
    }

    public void addLines(List<Line> Lines)
    {
          //primero verifica la linea de arriba, despues izq, despues derecha, despues abajo. 
        foreach (Line l in Lines)
        {
            if(l.GetComponent<Transform>().position.x == Position.x  && l.GetComponent<Transform>().position.y == Position.y+0.5f)
            {
                LinesSquare[0] = l;
            }
            if (l.GetComponent<Transform>().position.x == Position.x-0.5f && l.GetComponent<Transform>().position.y == Position.y)
            {
                LinesSquare[1] = l;
            }
            if (l.GetComponent<Transform>().position.x == Position.x+0.5f && l.GetComponent<Transform>().position.y == Position.y)
            {
                LinesSquare[2] = l;
            }
            if (l.GetComponent<Transform>().position.x == Position.x && l.GetComponent<Transform>().position.y == Position.y-0.5f)
            {
                LinesSquare[3] = l;
            }
        }
    }

    void Update()
    {
        
    }
}
