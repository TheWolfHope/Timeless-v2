using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public PlayerMovement _playerMovement;
    private Animator _animator;
    public bool canMove = true;

    private const string _horizontal = "Horizontal";
    private const string _vertical = "Vertical";

    private const string _lastHorizontal = "LastHorizontal";
    private const string _lastVertical = "LastVertical";

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(canMove ==true)
        {
            _animator.SetFloat(_horizontal, _playerMovement.moveDir.x);
            _animator.SetFloat(_vertical, _playerMovement.moveDir.y);       
  

            if (_playerMovement.moveDir != Vector2.zero)
            {
                _animator.SetFloat(_lastHorizontal, _playerMovement.moveDir.x);
                _animator.SetFloat(_lastVertical, _playerMovement.moveDir.y);
            }
        }
        
    }
}
