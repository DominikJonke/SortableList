using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortableList.Test
{
    [TestClass]
    public class SortableListTests
    {
        [TestMethod()]
        public void Sort_Integers_ShouldBeInCorrectOrder()
        {
            // Arrange
            SortableList sortableList = new SortableList();
            sortableList.Insert(3);
            sortableList.Insert(1);
            sortableList.Insert(5);
            // Act  werden automatisch sortiert eingefügt
            // Assert 
            IComparable[] objects = sortableList.ToArray();
            Assert.AreEqual(1, objects[0]);
            Assert.AreEqual(3, objects[1]);
            Assert.AreEqual(5, objects[2]);
        }

        [TestMethod()]
        public void Sort_Strings_ShouldBeInCorrectOrder()
        {
            // Arrange
            SortableList sortableList = new SortableList();
            sortableList.Insert("MMMM");
            sortableList.Insert("BBBB");
            sortableList.Insert("UUUU");
            // Act  werden automatisch sortiert eingefügt
            // Assert 
            IComparable[] objects = sortableList.ToArray();
            Assert.AreEqual("BBBB", objects[0]);
            Assert.AreEqual("MMMM", objects[1]);
            Assert.AreEqual("UUUU", objects[2]);
        }
    }
}
