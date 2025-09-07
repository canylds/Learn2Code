using DSAPlayground.Arrays;
using DSAPlayground.LinkedLists;

ArrayExamples.RunAll();
MySinglyLinkedListHelper();


static void MySinglyLinkedListHelper()
{
    Console.WriteLine("--- My Singly Linked List ---");

    MySinglyLinkedList<int> mySinglyLinkedList = new MySinglyLinkedList<int>(firstData: 4);
    mySinglyLinkedList.AddLast(3);
    mySinglyLinkedList.AddFirst(5);
    mySinglyLinkedList.RemoveFirst();
    mySinglyLinkedList.RemoveLast();

    mySinglyLinkedList.PrintList();
}