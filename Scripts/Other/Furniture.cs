using System;
using System.Linq;
using System.Runtime.InteropServices;
using Mirror;
using Mirror.RemoteCalls;
using UnityEngine;

public abstract class Furniture : Mirror.NetworkBehaviour
{
	
	[field: SerializeField] public Vector2Int Size { get; protected set; }

	[SerializeField][Range(0,100)][Tooltip("Sets the cost in the housebuilder.")] private int cost;
	[SerializeField][Tooltip("I have no idea what this does... -NaV")] private bool unique;

}