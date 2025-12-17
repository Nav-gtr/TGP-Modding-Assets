using System;
using UnityEngine.UI;

public class ItemSlot
{	
	private Item _item;
	public bool needsVisualUpdate;
	public Action OnItemChanged;
}