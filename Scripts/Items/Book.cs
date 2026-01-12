using System;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(PickupItemAction))]
[RequireComponent(typeof(ItemObject))]

public class Book : InteractableAction
{
	public string file;
	public string[] vars;
	public Font font;
	public int fontSize;
	public TextAnchor alignment;
	public Sprite[] image = new Sprite[0];
	public Sprite cover;
}
