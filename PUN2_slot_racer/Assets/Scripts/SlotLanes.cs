using UnityEngine;

using Photon.Pun.Demo.SlotRacer.Utils;

namespace Photon.Pun.Demo.SlotRacer
{
	/// <summary>
	/// Define Slot lanes and grid positions placeholders.
	/// This is a convenient approach to visually define the lanes and their grid positions without any complicated editors and setup framework.
	/// </summary>
	public class SlotLanes : MonoBehaviour {

		/// <summary>
		/// Instance Pointer to access GridPositions
		/// </summary>
		public static SlotLanes Instance;

		/// <summary>
		/// The grid positions.
		/// </summary>
		public SplinePosition[] GridPositions;

		void Awake()
		{
			Instance = this;
		}
	}
}