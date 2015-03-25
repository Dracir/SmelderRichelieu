using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Magicolo;

public class Spitter : StateLayer {
	
	[Min] public float reloadTime = 0.1F;
	public Vector2 initialVelocity = new Vector2(0, 5);
	public Vector2 gravity = new Vector2(0, 5);
	public GameObject spitPrefab;
	
	[Disable] public int spitHash = Animator.StringToHash("Spit");
	
	bool _animatorCached;
	Animator _animator;
	public Animator animator { 
		get { 
			_animator = _animatorCached ? _animator : GetComponent<Animator>();
			_animatorCached = true;
			return _animator;
		}
	}
}