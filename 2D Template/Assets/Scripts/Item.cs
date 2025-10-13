using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Item : ScriptableObject
{
    
    [Header("Only gameplay")]
    public TileBase tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);
    public Light2D.LightType light;
    public Color lightColor = Color.white;
    public float lightIntensity = 1;
    public float lightRadius = 1;


    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;
}

public enum ItemType
{
     BuildingBlock,
    Tool,
   LightSource
}
public enum ActionType
{
      Dig,
     Mine,
    Light
}