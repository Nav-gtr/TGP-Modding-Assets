using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour, AutoPickup
{

    public void Pickup(Player player)
    {

    }
	
	public void Spring()
	{
		if (this.anim != null)
		{
			this.anim.SetTrigger("sprung");
			this.active = true;
		}
		
		if (this.audio != null)
		{
			this.audio.Play();
		}
		
	}
	
	private void Dummy() //Made this so Unity would stop warning me about it.
	{
		if (!this.canTrigger && !this.active)
		{
			return;
		}
	}
	
	public float damage;
	public float effectDuration;
	[Tooltip("Make sure the trigger param is named \"sprung\" in the animator menu")]public Animator anim;
	public AudioSource audio;
	public bool continuousDamage;
	[Tooltip("Unknown use")]public bool pushesPlayer;
	public bool resetsAfterSpring;
	private bool canTrigger = true;
	private bool active;
	[Tooltip("Needs an effect duration greater than zero to do anything.")]public Trap.TrapEffect trapEffect;
	[Tooltip("Unknown use")]public bool areaOfEffect;
	public bool spawnsEnemies;
	private bool isEffectCloudActive;
	
	public enum TrapEffect {Slow, Burning, Radiation, Poison, Weaken}
}
