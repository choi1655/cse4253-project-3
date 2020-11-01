using Choi.SceneGraph;

namespace Choi.SceneGraphCore
{
    public abstract class DrawableNodeBase: IDrawableNode
    {
        public DrawableNodeBase(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            visitor.PostVisit(this);
        }

        public string Name
        {
            get;
            protected set;
        }
    }
}
