using Godot;
using System;

public class QickDuck : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    float wait = 0.5f;
    float lastShoot;
    PackedScene fire = (PackedScene)ResourceLoader.Load("res://Fire.tscn");
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }
public void _on_Area2D_body_entered(Node koll)
{
     
}
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
      if (lastShoot >= wait)
      {
          Node2D loadedFire = (Node2D)fire.Instance();
          this.AddChild(loadedFire);
          loadedFire.GlobalPosition -= new Vector2(+80, +40);
          lastShoot = 0.0f;
      }
      lastShoot += delta;       
  }
}
