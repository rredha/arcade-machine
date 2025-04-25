using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z,
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells {get; private set;}

    public void Initialize()
    {
        //Debug.Log("Initialize() <- TetrominoData class <- Tetromino.cs got called");
        this.cells = Data.Cells[this.tetromino];
        //Debug.Log("tetromino : " + this.tetromino);
       // Debug.Log(Data.Cells[this.tetromino].ToString());
    }
}