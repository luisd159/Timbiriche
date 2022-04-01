using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public List<Line> LinesSquare = new List<Line>();
    public Vector2 Position;
    public int id;

    public void Init(int id)
    {
        this.id = id;
    }


    public void addLines(List<Line> Lines)
    {
        //primero verifica la linea de arriba, despues izq, despues derecha, despues abajo. 
        Position = this.GetComponent<Transform>().position;
        foreach (Line l in Lines)
        {
            if(l.GetComponent<Transform>().position.x == Position.x  && l.GetComponent<Transform>().position.y == Position.y+0.5f)
            {
                //  LinesSquare[0] = l;
                LinesSquare.Add(l);
            }
            if (l.GetComponent<Transform>().position.x == Position.x - 0.5f && l.GetComponent<Transform>().position.y == Position.y)
            {
               // LinesSquare[1] = l;
                LinesSquare.Add(l);
            }
            if (l.GetComponent<Transform>().position.x == Position.x + 0.5f && l.GetComponent<Transform>().position.y == Position.y)
            {
                //LinesSquare[2] = l;
                LinesSquare.Add(l);
            }
            if (l.GetComponent<Transform>().position.x == Position.x && l.GetComponent<Transform>().position.y == Position.y - 0.5f)
            {
                //LinesSquare[3] = l;
                LinesSquare.Add(l);
            }
        }
    }

    public bool Completed()
    {
        foreach (Line l in LinesSquare)
        {
            if (l.Coloreado == false)
            {
                return false;
            }
        }
        return true;
    }

    public void MostrarLista()
    {
        foreach (Line l in LinesSquare)
        {
            Debug.Log(id);
        }
    }

}
