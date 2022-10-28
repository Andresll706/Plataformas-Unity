using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellComponent : MonoBehaviour
{
    public Cell[] _tablero;
}
[System.Serializable]
public class Cell
{
    public Fila _fila;
    public Columna _columna;
}
public enum Fila { A, B, C, D, E, F, G, H }
public enum Columna { UNO, DOS, TRES, CUATRO, CINCO, SEIS, SIETE, OCHO }

