using System.Collections.Generic;
using Choi.SceneGraph;

namespace Choi.SceneGraphCore
{
    public class GroupNode: IGroupNode
    {
        public string Name
        {
            get;
            private set;
        }

        public GroupNode(string name)
        {
            this.Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            foreach (ISceneNode child in children)
            {
                child.Accept(visitor);
            }
            visitor.PostVisit(this);
        }

        public void AddChild(ISceneNode child)
        {
            children.Add(child);
        }

        #region Member variables

        private const int INITIAL_SIZE = 8;
        // List to keep track of the cihldren for the group
        private IList<ISceneNode> children = new List<ISceneNode>(INITIAL_SIZE);

        #endregion
    }
}
