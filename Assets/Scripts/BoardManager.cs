using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance;
    public Slider tamaño;
    public int Width;
    public int Heigth;
    public Point PointPrefab;
    public Line LinePrefab;
    public Square SquarePrefab;
    public List<Line> Lines = new List<Line>();
    public List<Square> Squares = new List<Square>();

    public void Awake()
    {
        Instance = this;
        Width = PlayerPrefs.GetInt("tamaño");
        Heigth = PlayerPrefs.GetInt("tamaño");
    }

    void Start()
    {
        GenerateBoard();
        CheckBox();
    }


    public void GenerateBoard()
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
                Square s = Instantiate(SquarePrefab, new Vector2(j + 0.5f, i + 0.5f), Quaternion.identity);
                s.addLines(Lines);
                Squares.Add(s);
            }
        }
    }

    

    public void CheckBox()
    {
        foreach (Square s in Squares)
        {
            if (s.Completed() == true)
            {
                Debug.Log("SE PUEDE PINTAR");
            }
        }
    }



    
 
    public void SetLine(Line l)
    {
        GameManager.Instance.SwitchPlayer();
    }
}              
