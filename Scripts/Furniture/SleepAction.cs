using System;
using UnityEngine;

public class SleepAction : InteractableAction
{
	[SerializeField][Tooltip("The transform should be from a separate object.")] private Transform sleepPosition;
	[SerializeField][Tooltip("Current valid strings are either \"Sit\" or \"Sleep\".")] private string trigger;

}
