using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
namespace LinkedListTest
{
    [TestClass]
    public class NodeTest
    {
        LinkedListNode<int> linkedList = new LinkedListNode<int>();

        [TestMethod]
        public void SearchTest1()
        {
            int actual, expected;
            linkedList.AddFront(70);
            linkedList.AddFront(30);
            linkedList.AddFront(56);
            actual = linkedList.Search(70);
            expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SearchTest2()
        {
            linkedList.AddFront(70);
            linkedList.AddFront(30);
            linkedList.AddFront(56);
            //act
           int  actual = linkedList.Search(30);
            int expected = 1;
            linkedList.InsertMiddle(45, 30);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
