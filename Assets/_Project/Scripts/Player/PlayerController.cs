using UnityEngine;
using UnityEngine.InputSystem;

namespace Cronos_Hackathon_Starter_Sample
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Main Components")]
        public PlayerMovementController movement;
        public PlayerInputController input;
        public PlayerWalletAddress walletAddress;

        [Header("Other Components")]
        [SerializeField] private AudioSource audioSource;
        
        
        public void OnDance(InputValue value)
        {
            if (value.isPressed)
            {
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }
        }
    }
}

