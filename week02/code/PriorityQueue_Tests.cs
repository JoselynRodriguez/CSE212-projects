using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities.
    // Expected Result: Highest priority item dequeued first.
    public void TestPriorityQueue_DequeueHightestPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 3);
        priorityQueue.Enqueue("high", 5);

        Assert.AreEqual("high", priorityQueue.Dequeue());
    }

    [TestMethod]

    // Scenario: Enqueue items with same priority.
    // Expected Result: FIFO order respected (first in, first out).
    public void TestPriorityQueue_FifoOnTie()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 3);
        priorityQueue.Enqueue("second", 3);

        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
    }

    [TestMethod]

    // Scenario: Enqueue multiple items, remove highest priority, then continue.
    // Expected Result: After removing highest, next highest is dequeued.
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("high1", 5);
        priorityQueue.Enqueue("medium", 3);
        priorityQueue.Enqueue("high2", 5);

        Assert.AreEqual("high1", priorityQueue.Dequeue()); // first high priority
        Assert.AreEqual("high2", priorityQueue.Dequeue()); // second high priority
        Assert.AreEqual("medium", priorityQueue.Dequeue()); // then medium
        Assert.AreEqual("low", priorityQueue.Dequeue()); // finally low
    }

    [TestMethod]

    /// Scenario: Try to dequeue from empty queue.
    /// Expected Result: InvalidOperationException with message "The queue is empty."
 
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}