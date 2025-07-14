// 147. Insertion Sort List
// Medium
//     Topics
// premium lock icon
//     Companies
// Given the head of a singly linked list, sort the list using insertion sort, and return the sorted list's head.
//
//     The steps of the insertion sort algorithm:
//
// Insertion sort iterates, consuming one input element each repetition and growing a sorted output list.
//     At each iteration, insertion sort removes one element from the input data, finds the location it belongs within the sorted list and inserts it there.
//     It repeats until no input elements remain.
//     The following is a graphical example of the insertion sort algorithm. The partially sorted list (black) initially contains only the first element in the list. One element (red) is removed from the input data and inserted in-place into the sorted list with each iteration.
//
//
//  
//
//     Example 1:
//
//
// Input: head = [4,2,1,3]
// Output: [1,2,3,4]
// Example 2:
//
//
// Input: head = [-1,5,3,4,0]
// Output: [-1,0,3,4,5]
//  
//
// Constraints:
//
// The number of nodes in the list is in the range [1, 5000].
// -5000 <= Node.val <= 5000


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        
        ListNode dummy = new ListNode(0); // Dummy node to serve as the starting point of the sorted list
        ListNode current = head;         // Current node in the original list
        
        while (current != null) {
            ListNode next = current.next; // Save the next node before we change current.next
            ListNode prev = dummy;        // Start from the beginning of the sorted list
            
            // Find the correct position to insert the current node in the sorted list
            while (prev.next != null && prev.next.val < current.val) {
                prev = prev.next;
            }
            
            // Insert the current node into the sorted list
            current.next = prev.next;
            prev.next = current;
            
            // Move to the next node in the original list
            current = next;
        }
        
        return dummy.next;
    }
}

class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();
        
        // Example 1
        ListNode head1 = new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3))));
        ListNode result1 = solution.InsertionSortList(head1);
        PrintList(result1); // Output should be 1 -> 2 -> 3 -> 4
        
        // Example 2
        ListNode head2 = new ListNode(-1, new ListNode(5, new ListNode(3, new ListNode(4, new ListNode(0)))));
        ListNode result2 = solution.InsertionSortList(head2);
        PrintList(result2); // Output should be -1 -> 0 -> 3 -> 4 -> 5
    }
    
    static void PrintList(ListNode head) {
        ListNode current = head;
        while (current != null) {
            Console.Write(current.val);
            if (current.next != null) {
                Console.Write(" -> ");
            }
            current = current.next;
        }
        Console.WriteLine();
    }
}