using Godot;
using System;

public class Fire : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    bool hitted = false;
    Vector2 velocity = new Vector2();
    public override void _Ready()
    {
        Random randr = new Random();
        velocity.x = randr.Next(0, 100);
        velocity.y = randr.Next(0,100);
        velocity = velocity.Normalized();
        velocity = velocity * -1;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
      KinematicCollision2D coll = this.MoveAndCollide(velocity);
      if (coll != null)
      {
          if (((Node2D)coll.Collider).Name == "Kämpfer" && hitted == false)
          {
              Random crit = new Random();
              int critT = crit.Next(0,2);
              if (critT == 0)
              {
                  ((Kämpfer)coll.Collider).Hit();
              }
              else
              {
                  ((Kämpfer)coll.Collider).Hit(true);
              }
              hitted = true;
          }
          else
          {
              Free();
          }
      }
  }
}
