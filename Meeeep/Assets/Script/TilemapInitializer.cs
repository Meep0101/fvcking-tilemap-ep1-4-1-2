using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapInitializer : Singleton<TilemapInitializer>
{
    [SerializeField] List<BuildingCategory> categoriesToCreateTilemapFor;
    [SerializeField] Transform grid;

    private void Start(){
        foreach (BuildingCategory category in categoriesToCreateTilemapFor){
            GameObject obj = new GameObject(category.name);

            Tilemap map = obj.AddComponent<Tilemap>();
            TilemapRenderer tr = obj.AddComponent<TilemapRenderer>();

            obj.transform.SetParent(grid);

            tr.sortingOrder = category.SortingOrder;

            category.Tilemap = map;
        }
    }



}
