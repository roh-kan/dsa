using DataStructures.HashTable;
using Xunit;

namespace DataStructures.HashTableTest
{
    public class HashSetTest
    {
        [Fact]
        public void ValidateAdd()
        {
            // Arrange
            HashSet myHashSet = new();

            // Act
            int[] keys = new int[] { 1, 101, 3 };
            foreach (var item in keys)
            {
                myHashSet.Add(item);
            }

            // Assert
            Node[] nodes = new Node[100];
            nodes[1] = new Node(1, null)
            {
                Next = new Node(101, null)
            };
            nodes[3] = new Node(3, null);

            Assert.Equal(myHashSet.arr[1].Val, nodes[1].Val);
            Assert.Equal(myHashSet.arr[1].Next.Val, nodes[1].Next.Val);
            Assert.Equal(myHashSet.arr[3].Val, nodes[3].Val);

        }

        [Fact]
        public void ValidateRemove()
        {
            // Arrange
            HashSet myHashSet = new();
            int[] keys = new int[] { 1, 101, 3 };
            foreach (var item in keys)
            {
                myHashSet.Add(item);
            }

            // Act
            myHashSet.Remove(3);
            myHashSet.Remove(101);

            // Assert
            Node[] nodes = new Node[100];
            nodes[1] = new Node(1, null);

            Assert.Equal(myHashSet.arr[1].Val, nodes[1].Val);
            Assert.Equal(myHashSet.arr[1].Next?.Val, nodes[1].Next?.Val);
            Assert.Equal(myHashSet.arr[3]?.Val, nodes[3]?.Val);
            Assert.NotEqual(myHashSet.arr[3]?.Val, keys[2]);

        }

        [Fact]
        public void ValidateContains()
        {
            // Arrange
            HashSet myHashSet = new();
            int[] keys = new int[] { 1, 101, 3 };
            foreach (var item in keys)
            {
                myHashSet.Add(item);
            }

            // Act and Assert

            Assert.True(myHashSet.Contains(3));
            Assert.True(myHashSet.Contains(1));
            Assert.True(myHashSet.Contains(101));
            Assert.False(myHashSet.Contains(30));
            Assert.False(myHashSet.Contains(11));
        }
    }
}
