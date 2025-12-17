using System;
using System.Collections;
using System.Linq;
using Mirror;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public abstract class ItemAcceptorMono : ClickOpen
{
	[field: SerializeField] public ItemSlots ItemSlot { get; private set; }
	[SerializeField] private Animator anim;
	[SerializeField] protected bool ejectItems;
}