namespace Choi.SceneGraph
{
    public interface ISceneNode
    {
        void Accept(IVisitor visitor);
        string Name { get; }
    }
}
