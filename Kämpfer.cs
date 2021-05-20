using Godot;
using System;

public class Kämpfer : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    [Export]
    private int geschwindigkeit = 10;

    public int Leben { get; set; }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
      MoveAndSlide(new Vector2(1 * geschwindigkeit, 0));
  }

  public void _on_Sicht_body_entered(Node kollidierterBody)
  {
     Vector2 ziel = ((Node2D)kollidierterBody).Position;
  }
}
