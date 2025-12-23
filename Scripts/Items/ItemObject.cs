using System;
using Mirror;
using Mirror.RemoteCalls;
using UnityEngine;

[RequireComponent(typeof(NetworkTransform))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(RegionChild))]

public class ItemObject : NetworkBehaviour
{
	[SerializeField][HideInInspector] private Rigidbody body;
	[SerializeField][HideInInspector] private NetworkTransform networkTransform;
	[SerializeField][HideInInspector] private RegionChild regionChild;
	
	public void OnValidate()
	{
		//Set RigidBody to component (use this.GetComponent() to do so I think. -N 
		//Yeah, read the documentation and seeing as this is a monoscript, we don't need to use this.GetComponent. We can just use GetComponent. -V
		// Null said something about onstart method.-V 
		//Scratch that last one, OnValidate is the only one that seems to work while in the editor.-V
		body = GetComponent<Rigidbody>();
		networkTransform = GetComponent<NetworkTransform>();
		regionChild = GetComponent<RegionChild>();
	}
	
}