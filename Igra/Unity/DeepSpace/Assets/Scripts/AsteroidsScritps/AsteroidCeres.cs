//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
namespace AssemblyCSharp
{
	public class AsteroidCeres : Asteroid
	{
		public AsteroidCeres ()
		{
			Health = 2;
		}
		public override void update (GameObject secondObject){
			if (secondObject.tag == "Bullet") {
				Destroy(secondObject);
				Health -= 1;
				AudioSource source = gameObject.GetComponent<AudioSource>();
				source.Stop();
				AudioSource.PlayClipAtPoint(source.clip, transform.position);
				if(Health <= 0) {
					destroyMe();
					ship.Score++;
				}

			}
			if( secondObject.tag == "Bomba"){
				Destroy(secondObject);
				Health -= 2;
				AudioSource source = gameObject.GetComponent<AudioSource>();
				source.Stop();
				AudioSource.PlayClipAtPoint(source.clip, transform.position);
				if(Health <= 0) {
					destroyMe();
					ship.Score++;
				}

			}
			if (secondObject.tag == "Ship") {
				ship.Shields -= (int)Random.Range(40,70);
				ship.Speed = ship.Speed - ship.Speed * 1.7f;
				AudioSource source = gameObject.GetComponent<AudioSource>();
				source.Stop();
				AudioSource.PlayClipAtPoint(source.clip, transform.position);
				destroyMe();
			}
		}
	}
}

