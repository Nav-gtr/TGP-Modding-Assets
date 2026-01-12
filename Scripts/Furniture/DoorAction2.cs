using System;
using UnityEngine;
using UnityEngine.AI;

public class DoorAction2 : InteractableAction, AutoPickup
{
	[SerializeField] private Transform target;
	[SerializeField] private Transform target2;
}
