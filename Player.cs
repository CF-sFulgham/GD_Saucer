using Godot;
using System;

public partial class Player : RigidBody2D
{
	private bool _isMoving = false;
	private PhysicsDirectBodyState2D _state;
	private Vector2 _direction;
	private float _torque = 100;
	
	public override void _Ready()
	{
	}
	
	public override void _IntegrateForces(PhysicsDirectBodyState2D state)
	{
		if(!this._isMoving){
			this._state = state;
			// GD.Print("calls to method");
			// state.ApplyForce(new Vector2(25, 0));
			this._isMoving = true;
		}
		
		if (Input.IsActionPressed("move_up"))
			this._direction = new Vector2(0, -this._torque);
			
		if (Input.IsActionPressed("move_down"))
			this._direction = new Vector2(0, this._torque);
		
		if (Input.IsActionPressed("move_left"))
			this._direction = new Vector2(-this._torque, 0);
			
		if (Input.IsActionPressed("move_right"))
			this._direction = new Vector2(this._torque, 0);
	}
	
	public override void _PhysicsProcess(double delta)
	{
		if(this._state != null){
			this._state.ApplyForce(this._direction);
		}
	}
}
