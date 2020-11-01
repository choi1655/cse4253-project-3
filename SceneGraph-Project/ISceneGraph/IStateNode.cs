namespace Choi.SceneGraph
{
    public interface IStateNode: ISceneNode
    {
        void Apply();
        void UnApply();
    }
}
