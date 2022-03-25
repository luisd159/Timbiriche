using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Width = 4;
    public int Heigth = 4;
    public Point PointPrefab;

    public void awake()
    {
        Instance = this;
    }

    void Start()
    {
        GenerateBoard();
    }

    private void GenerateBoard()
    {
        for (int i = 0; i < Heigth; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                var p = new Vector2(i, j);
                Instantiate(PointPrefab, p, Quaternion.identity);
            }
        }
        var center = new Vector2((float)Heigth / 2 - 0.5f, (float)Width / 2 - 0.5f);

        Camera.main.transform.position = new Vector3(center.x, center.y, -0.5f);
    }

}
