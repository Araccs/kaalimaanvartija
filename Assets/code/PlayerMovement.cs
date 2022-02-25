using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class PlayerMovement : MonoBehaviour
    {

        private NewPlayerInputs playerInput;
        private Rigidbody2D rb;
        public Animator animator;

        [SerializeField] private float speed = 10f;


        void Awake()
        {
            playerInput = new NewPlayerInputs();
            rb = GetComponent<Rigidbody2D>();
            animator= GetComponent<Animator>();
        }

        private void OnEnable()
        {
            playerInput.Enable();
        }

        private void OnDisable()
        {
            playerInput.Disable();
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector2 moveInput = playerInput.Movement.Move.ReadValue<Vector2>();
            rb.velocity = moveInput * speed;
            animator.SetFloat("Horizontal", moveInput.x);
            animator.SetFloat("Vertical", moveInput.y);
            animator.SetFloat("Speed", moveInput.sqrMagnitude);


        }
    }
}
