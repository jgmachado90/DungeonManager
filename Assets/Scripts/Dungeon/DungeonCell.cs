using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCell : MonoBehaviour
{
    private DungeonGenerator.DungeonCellType _cellType = DungeonGenerator.DungeonCellType.Begin;

    public DungeonCellCoordinates myCoordinates = new DungeonCellCoordinates();

    public DungeonGenerator.DungeonCellType CellType
    {
        get
        {
            return _cellType;
        }
        set
        {
            _cellType = value;
        }
    }

    public bool alreadyGenerated = false;

    public DungeonCell leftCell;
    public DungeonCell rightCell;
    public DungeonCell upCell;
    public DungeonCell downCell;

    public Transform upConnection;
    public Transform leftConnection;
    public Transform rightConnection;
}
