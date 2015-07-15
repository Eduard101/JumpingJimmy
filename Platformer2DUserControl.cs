 using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
			if (Input.GetMouseButtonDown (0))

					jump = true;
					
        }

        private void FixedUpdate()
        {
			character.Move(0, false, jump);
            jump = false;
        }
    }
}