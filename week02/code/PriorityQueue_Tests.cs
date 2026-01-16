using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
    // run until the queue is empty
    // Expected Result: Alice, Bob, Charlie, etc.
    // Defect(s) Found: 
    // - PersonQueue.Enqueue was inserting at the front instead of the back, breaking FIFO order.

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var steve = new PriorityQueue();
        steve.Enqueue("Alice", 5);
        steve.Enqueue("Bob", 10);
        steve.Enqueue("Charlie", 7);

        Assert.AreEqual("Bob", steve.Dequeue());
        Assert.AreEqual("Charlie", steve.Dequeue());
        Assert.AreEqual("Alice", steve.Dequeue());
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
    // After running 5 times, add George with 3 turns.  Run until the queue is empty.
    // Expected Result: Alice, Bob, Charlie, etc.
    // Defect(s) Found: None, passes with proper FIFO behavior

    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        var kalala = new PriorityQueue();
        kalala.Enqueue("Alice", 1);
        kalala.Enqueue("Bob", 1);
        kalala.Enqueue("Charlie", 1);

        // FIFO
        Assert.AreEqual("Alice", kalala.Dequeue());
        Assert.AreEqual("Bob", kalala.Dequeue());
        Assert.AreEqual("Charlie", kalala.Dequeue());
        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}