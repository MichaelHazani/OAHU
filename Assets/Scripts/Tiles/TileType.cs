using UnityEngine;
using System.Collections;

public static class TileType
{
	//Enumerators for tile and element types
	public enum tile: int{DESERT,MARSH,FOREST,LAKE,MOUNTAIN,PLAIN,CRAGS,GOAL};
	public enum element: int{EARTH,AIR,WATER,FIRE};
	public enum disaster: int{STORM,VOLCANO,FLOOD,EARTHQUAKE};
}