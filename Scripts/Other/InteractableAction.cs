using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Interactable))]

public class InteractableAction : MonoBehaviour
{
    [SerializeField][Tooltip ("I have no idea what the fuck this even does.")] protected Sprite sprite;
	[SerializeField][Tooltip ("I have no idea what the fuck this even does.")] protected string desc;
}
