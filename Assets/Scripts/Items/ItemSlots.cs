using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mirror;
using Mirror.RemoteCalls;
using UnityEngine;

public class ItemSlots : NetworkBehaviour
{
	public Action<bool> OnAnimate;
	private ItemSlot[] slots;
}