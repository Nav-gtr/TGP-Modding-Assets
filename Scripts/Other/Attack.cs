using System;

public class Attack
{
	public Attacking source;
	public Attackable target;
	public float damage;
	public delegate void Handler(Attack attack);
}