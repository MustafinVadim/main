namespace Easy;

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null)
            return list2;

        if (list2 is null)
            return list1;

        var head = new ListNode();
        var current = head;

        do
        {
            if (list1 == null)
            {
                current.next = list2;
                break;
            }

            if (list2 == null)
            {
                current.next = list1;
                break;
            }

            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
                current = current.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
                current = current.next;
            }
        } while (list1 != null || list2 != null);

        return head.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}