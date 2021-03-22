using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public enum DungeonCellType { Begin, End, Batlle, Boss, Chest, Rest};
    public DungeonCell firstCell;
    public List<DungeonCell> dungeonCells = new List<DungeonCell>();

    public GameObject dungeonCellPrefab;

    public Sprite dungeonSpriteBattle1;
    public Sprite dungeonSpriteBattle2;
    public Sprite dungeonSpriteBattle3;
    public Sprite dungeonSpriteBoss;
    public Sprite dungeonSpriteArrow;
    public Sprite dungeonSpriteChest;

    public int maxDepth;


    private void Start()
    {
        firstCell.myCoordinates.X = 0;
        firstCell.myCoordinates.Y = 0;
        dungeonCells.Add(firstCell);

        GenerateDungeon();
    }

    private void GenerateDungeon()
    {
        DungeonCell secondCell = null;
        if(firstCell.upCell == null)
        {
            secondCell = GenerateCell(firstCell, 1, true);
            secondCell.CellType = DungeonCellType.Batlle;
            secondCell.GetComponent<SpriteRenderer>().sprite = dungeonSpriteBattle1;
        }

        GenerateRecursively(secondCell, maxDepth);

    }

    private void GenerateRecursively(DungeonCell root, int depth)
    {
      
        if (depth <= 0)
            return;
        if (root.upCell == null)
        {
            root.upCell = GenerateCell(root, 1, false);
            if (root.upCell != null && !root.upCell.alreadyGenerated)
            {
                root.upCell.alreadyGenerated = true;
                depth--;
                GenerateRecursively(root.upCell, depth);
            }
        }
        if (root.leftCell == null)
        {
            root.leftCell = GenerateCell(root, 0, false);
            if (root.leftCell != null && !root.leftCell.alreadyGenerated)
            {
                root.leftCell.alreadyGenerated = true;
                depth--;
                GenerateRecursively(root.leftCell, depth);
            }
        }

        if (root.rightCell == null)
        {
            root.rightCell = GenerateCell(root, 2, false);
            if (root.rightCell != null && !root.rightCell.alreadyGenerated)
            {
                root.rightCell.alreadyGenerated = true;
                depth--;
                GenerateRecursively(root.rightCell, depth);
            }
        }

    

       
    }

  

    //Direction: 0 = left, 1 = up, 2 = right, 3 = down;
    private DungeonCell GenerateCell(DungeonCell rootCell, int direction, bool fullChance)
    {

        DungeonCell someoneAlready = HasSomeoneInTheCoordinate(rootCell.myCoordinates.X, rootCell.myCoordinates.Y, direction, rootCell);
        if(someoneAlready != null)
        {
            var rNG = UnityEngine.Random.Range(0, 100);
            if (rNG < 20 && direction == 1)
            {
                someoneAlready.downCell = rootCell;
                rootCell.upCell = someoneAlready;
                rootCell.upConnection.gameObject.SetActive(true);
                //rootCell.upConnection.GetComponent<SpriteRenderer>().color = Color.red;
                return someoneAlready;
            }
            return null;
        }
       


        if (!fullChance)
        {
            var rNG = UnityEngine.Random.Range(0, 100);
            if (rNG < 20)
            {
                if (direction == 0)
                    return null;
                if (direction == 1)
                    return null;
                if (direction == 2)
                    return null;
                if (direction == 3)
                    return  null;

            }
        }

        DungeonCell newDungeonCell = null;

        if(direction == 0) {

            GameObject dungeonCellGO = Instantiate(dungeonCellPrefab, rootCell.transform.position, Quaternion.identity, null);
            newDungeonCell = dungeonCellGO.GetComponent<DungeonCell>();
            newDungeonCell.myCoordinates.X = rootCell.myCoordinates.X - 1;
            newDungeonCell.myCoordinates.Y = rootCell.myCoordinates.Y;
            newDungeonCell.transform.position = new Vector3(newDungeonCell.myCoordinates.X * 10, newDungeonCell.myCoordinates.Y * 10, newDungeonCell.transform.position.z);
            rootCell.leftConnection.gameObject.SetActive(true);
            rootCell.leftCell = newDungeonCell;
            newDungeonCell.rightCell = rootCell;
        }
        
        if (direction == 1) {
            GameObject dungeonCellGO = Instantiate(dungeonCellPrefab, rootCell.transform.position, Quaternion.identity, null);
            newDungeonCell = dungeonCellGO.GetComponent<DungeonCell>();
            newDungeonCell.myCoordinates.X = rootCell.myCoordinates.X;
            newDungeonCell.myCoordinates.Y = rootCell.myCoordinates.Y + 1;
            newDungeonCell.transform.position = new Vector3(newDungeonCell.myCoordinates.X * 10, newDungeonCell.myCoordinates.Y * 10, newDungeonCell.transform.position.z);
            rootCell.upConnection.gameObject.SetActive(true);
            rootCell.upCell = newDungeonCell;
            newDungeonCell.downCell = rootCell;
        }
        
        if (direction == 2) {
            GameObject dungeonCellGO = Instantiate(dungeonCellPrefab, rootCell.transform.position, Quaternion.identity, null);
            newDungeonCell = dungeonCellGO.GetComponent<DungeonCell>();
            newDungeonCell.myCoordinates.X = rootCell.myCoordinates.X + 1;
            newDungeonCell.myCoordinates.Y = rootCell.myCoordinates.Y;
            newDungeonCell.transform.position = new Vector3(newDungeonCell.myCoordinates.X * 10, newDungeonCell.myCoordinates.Y * 10, newDungeonCell.transform.position.z);
            rootCell.rightConnection.gameObject.SetActive(true);
            rootCell.rightCell = newDungeonCell;
            newDungeonCell.leftCell = rootCell;
        }
        if (direction == 3) {
            GameObject dungeonCellGO = Instantiate(dungeonCellPrefab, rootCell.transform.position, Quaternion.identity, null);
            newDungeonCell = dungeonCellGO.GetComponent<DungeonCell>();
            newDungeonCell.myCoordinates.X = rootCell.myCoordinates.X;
            newDungeonCell.myCoordinates.Y = rootCell.myCoordinates.Y - 1;
            newDungeonCell.transform.position = new Vector3(newDungeonCell.myCoordinates.X * 10, newDungeonCell.myCoordinates.Y * 10, newDungeonCell.transform.position.z);
            rootCell.downCell = newDungeonCell;
            newDungeonCell.upCell = rootCell;
        }
        CellTypeGenerator(newDungeonCell);
        dungeonCells.Add(newDungeonCell);
        return newDungeonCell;
    }

    private DungeonCell HasSomeoneInTheCoordinate(int x, int y, int dir, DungeonCell root)
    {
        int newX = x;
        int newY = y;

        if(dir == 0) 
            newX = x - 1;
        
        if (dir == 1)
            newY = y + 1;
        
        if (dir == 2)
            newX = x +1;
        
        if (dir == 3)
            newY = y - 1;
        

        foreach (DungeonCell dungeonCell in dungeonCells)
        {
            if(dungeonCell.myCoordinates.X == newX && dungeonCell.myCoordinates.Y == newY)
            {
                return dungeonCell;
            }
        }
        return null;
    }

    private void CellTypeGenerator(DungeonCell newDungeonCell)
    {
        var rNG = UnityEngine.Random.Range(0, 100);
        if(rNG > 30) {
            newDungeonCell.CellType = DungeonCellType.Batlle;
            newDungeonCell.GetComponent<SpriteRenderer>().sprite = dungeonSpriteBattle1;
        }
        else if(rNG > 10)
        {
            newDungeonCell.CellType = DungeonCellType.Chest;
            newDungeonCell.GetComponent<SpriteRenderer>().sprite = dungeonSpriteChest;
        }
        else
        {
            newDungeonCell.CellType = DungeonCellType.Boss;
            newDungeonCell.GetComponent<SpriteRenderer>().sprite = dungeonSpriteBoss;
        }
    }
}

public class DungeonCellCoordinates
{
    private int _x;
    public int X
    {
        get { return _x; }
        set { _x = value; }
    }

    private int _y;
    public int Y
    {
        get { return _y; }
        set { _y = value; }
    }



}
