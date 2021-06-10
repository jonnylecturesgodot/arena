using Godot;
using System;

public class Kämpfer : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    [Export]
    private int geschwindigkeit = 10;

    [Export]
    public int Leben { get; set; } = 100;

    Vector2 velocity = new Vector2();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        ((Label)GetTree().Root.GetNode("./Main/CanvasLayer/Label")).Text = Leben.ToString();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
      if (Input.IsActionPressed("ui_down"))
      {
        velocity.y = 1;
      }
      if (Input.IsActionPressed("ui_up"))
      {
        velocity.y = -1;
      }
      if (Input.IsActionPressed("ui_right"))
      {
        velocity.x = 1;
      }
      if (Input.IsActionPressed("ui_left"))
      {
        velocity.x = -1;
      }
      MoveAndSlide(velocity * geschwindigkeit);
      ((Label)GetTree().Root.GetNode("./Main/CanvasLayer/Label")).Text = Leben.ToString();
  }

  public void _on_Sicht_body_entered(Node kollidierterBody)
  {
     Vector2 ziel = ((Node2D)kollidierterBody).Position;
  }

  public void Hit()
  {
    Leben -= 1;
  }
  public void Hit(bool crit)
  {
    Leben -= 5;
  }

}
