using System;
using UnityEngine;

namespace Cronos_Hackathon_Starter_Sample
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Main Custom Components")]
        public PlayerMovementController movement;
        public PlayerInputController input;

        private void OnEnable()
        {
            input.EnableInput(false);
        }
    }
}

