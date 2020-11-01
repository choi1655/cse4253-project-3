using System;
namespace Choi.SceneGraphCore
{
    public class Cube: DrawableNodeBase
    {
        public Cube(string name): base(name)
        {
        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing a cube...");
        }
    }
}
