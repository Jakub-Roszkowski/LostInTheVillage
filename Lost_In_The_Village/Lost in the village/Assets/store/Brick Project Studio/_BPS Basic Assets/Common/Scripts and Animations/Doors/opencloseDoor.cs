using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{
		private PlayerInput playerInput;
		public PlayerInput.OnFootActions onFoot;
		void Awake()
		{
			playerInput = new PlayerInput();
			onFoot = playerInput.OnFoot;

		}

		void Update()
		{

		}

		private void OnEnable()
		{
			onFoot.Enable();
		}


		private void OnDisable()
		{
			onFoot.Disable();
		}






















		public Animator openandclose;
		public bool open;
		private Transform Player;

		void Start()
		{
			open = false;
			Player = FindObjectOfType<PlayerController>().transform;
		}

		void OnMouseOver()
		{
			{
				if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 15)
					{
						if (open == false)
						{
							if (onFoot.Interact.triggered)
							{
								StartCoroutine(opening());
							}
						}
						else
						{
							if (open == true)
							{
								if (onFoot.Interact.triggered)
								{
									StartCoroutine(closing());
								}
							}

						}

					}
				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}