using UnityEngine;

public class CharacterController2D : MonoBehaviour {

    private const float SkinWidth = .02f;
    private const int TotalHorizontalRays = 8;
    private const int TotalVerticalRays = 4;

    private static readonly float SlopeLimitTangant = Mathf.Tan(75f * Mathf.Deg2Rad);

    public LayerMask PlatformMask;
    public ControllerParameters2D DefaultParameters;

    public ControllerState2D State { get; private set; }
    public Vector2 Velocity { get { return _velocity; } }
    public bool CanJump{get { return false; }}

    private Vector2 _velocity;
    private Transform _transform;
    private Vector3 _localScale;
    private BoxCollider2D _boxCollider;

    private float
        _verticalDistanceBetweenRays, 
        _horizontalDistanceBetweenRays;

    public void Awake() {
        State = new ControllerState2D();
    }

    public void AddForce(Vector2 force) {
        _velocity = force;
    }

    public void SetForce(Vector2 force) {
        _velocity += force;
    }

    public void SetHorizontalForce(float x){
        _velocity.x = x;
    }

    public void SetVerticalForce(float y){
        _velocity.y = y;
    }

    public void Jump(){
    }

    public void LateUpdate() {
    }

    private void Move(Vector2 deltaMovement) { 
    }

    private void HandlePlatforms() {
    }

    private void CalculateRayOrigins() {
    }

    private void MoveHorizontally(ref Vector2 deltaMovement) {
    }

    private void MoveVertically(ref Vector2 deltaMovement) {
    }

    private void HandleVerticalSlope(ref Vector2 deltaMovement) {
    }

    private void HandleHorzontalSlope(ref Vector2 deltaMovement, float angle, bool isGoingRight) { 
    }

    public void OnTriggerEnter2D(Collider2D other) {
    }

    public void OnTriggerExit2D(Collider2D other){
    }


}
