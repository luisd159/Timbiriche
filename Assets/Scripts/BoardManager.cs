using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance;
    public int Width = 4;
    public int Heigth = 4;
    public Point PointPrefab;
    public Line LinePrefab;
    public Square SquarePrefab;
    public List<Line> Lines;
    public List<Square> Squares;
    Square s;

    public void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GenerateBoard();
    }

    private void GenerateBoard()
    {
        for (int i = 0; i < Heigth; i++) // Dibujar Puntos
        {
            for (int j = 0; j < Width; j++)
            {

                Instantiate(PointPrefab, new Vector2(i, j), Quaternion.identity);
            }
        }
        var center = new Vector2((float)Heigth / 2 - 0.5f, (float)Width / 2 - 0.5f);
        Camera.main.transform.position = new Vector3(center.x, center.y, -0.5f);

        for (int i = 0; i < Heigth; i++)  // Dibujar Lineas Horizontales
        {
            for (int j = 0; j < Width - 1; j++)
            {
                Lines.Add(Instantiate(LinePrefab, new Vector3(j + 0.5f, i, 1), Quaternion.Euler(0f, 0f, 90f)));
            }
        }

        for (int i = 0; i < Heigth - 1; i++)   // Dibujar Lineas Verticales
        {
            for (int j = 0; j < Width; j++)
            {
                Lines.Add(Instantiate(LinePrefab, new Vector3(j, i + 0.5f, 1), Quaternion.identity));
            }
        }

        for (int i = 0; i < Heigth - 1; i++) // Dibujar Cuadrados 
        {
            for (int j = 0; j < Width - 1; j++)
            {
                s = Instantiate(SquarePrefab, new Vector2(j + 0.5f, i + 0.5f), Quaternion.identity);
                s.addLines(Lines);
            }
        }

    }

    public void CheckSquare()
    {
        //bool a = s.LinesSquare[0].Coloreado && s.LinesSquare[1].Coloreado && s.LinesSquare[2].Coloreado && s.LinesSquare[3].Coloreado;
        for (int i = 0; i < s; i++)
        {
            if (s[1].LinesSquare[0].Coloreado && s[i].LinesSquare[1].Coloreado && s[i].LinesSquare[2].Coloreado && s[i].LinesSquare[3].Coloreado == true)
            {
                break;
            }
        }
        
    }
 
    public void SetLine(Line l)
    {
        GameManager.Instance.SwitchPlayer();
    }
}              
