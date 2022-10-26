using TISignalRChat.Models;

namespace TISignalRChat.DataContext
{
    public class FakeGroupDB
    {
        public List<Group> groups { get; set; }

        public FakeGroupDB()
        {
            groups = new List<Group>();
        }

        public void AddGroup(Group g)
        {
            
            groups.Add(g);
        }
    }
}
