using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ClickOpen : MonoBehaviour
{
	public static ClickOpen active;
	public static bool hovering;
	private static Texture2D cursorTexture;
	private int visibility;
}