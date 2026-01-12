using System;
using UnityEngine;

public class PickupItemAction : InteractableAction
{
	public string captchaCode;
	public Item targetItem;
	public bool objectIsItem = true;
	public bool consume = true;
	public ItemSlot notify;
}
