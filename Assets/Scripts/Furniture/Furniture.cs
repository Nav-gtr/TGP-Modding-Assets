using Mirror;
using Mirror.RemoteCalls;
using UnityEngine;

public abstract class Furniture : Mirror.NetworkBehaviour
{

[SerializeField][Min(0f)][Tooltip("Sets the cost of the furniture in the house builder.")] private int cost;
[SerializeField][Tooltip("I have no idea what this does... -NaV")] private bool unique;

}
