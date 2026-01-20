using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Test Case 1
    // Scenario:
    // Create a priority queue and enqueue the following people with priorities:
    // Alice (5), Bob (10), Charlie (7).
    // Then dequeue until the queue is empty.
    //
    // Expected Result:
    // Items should be dequeued in priority order (highest priority first):
    // Bob, Charlie, Alice.
    //
    // Test Result:
    // Passed – items were dequeued in the correct priority order.
    //
    // Defect(s) Found:
    // None.

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
    // Test Case 2
    // Scenario:
    // Create a priority queue and enqueue the following people with the same priority:
    // Alice (1), Bob (1), Charlie (1).
    // Dequeue all items.
    //
    // Expected Result:
    // Since all priorities are the same, items should be dequeued in FIFO order:
    // Alice, Bob, Charlie.
    //
    // Test Result:
    // Passed – FIFO order was preserved for equal priorities.
    //
    // Defect(s) Found:
    // None.

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