using UnityEngine;
// Change color based on events...
public class Pointer : MonoBehaviour
{
    private Camera _camera;
    private Collider2D _collider;
    [SerializeField] private Collider2D _otherCollider;

    private SpriteRenderer _spriteRenderer ;
    private bool _isMouseDown;
    private Vector3 _mousePosWorld;
    private Vector3 _mousePosScreen;
    private void Awake()
    {
        _camera = Camera.main;
        _collider = GetComponent<Collider2D>();
        _collider.isTrigger = true;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        _mousePosScreen = Input.mousePosition;
        if (_camera) _mousePosScreen.z = 10;
        _mousePosWorld = _camera.ScreenToWorldPoint(_mousePosScreen);
        // another route using isTouching ...
        if (_collider.IsTouching(_otherCollider)) DisplayContactCollider();

        //if (Physics2D.IsTouching(_collider, _otherCollider)) DisplayContactCollider();
        //var numberOfContacts = Physics2D.OverlapPoint(_mousePosWorld, new ContactFilter2D().NoFilter(), _overlapColliders);
        //if (numberOfContacts != Null ) DisplayContactCollider();


        transform.position = _mousePosWorld;
    }

    private void DisplayContactCollider()
    {
        Debug.Log("Hello");
    }
    /*
    private void OnMouseDown()
    {
        _isMouseDown = true;
    }
    private void OnMouseUp()
    {
        _isMouseDown = false;
    }
    */
}
