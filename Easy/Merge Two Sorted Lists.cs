namespace Teste.Easy;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

internal class Merge_Two_Sorted_Lists
{
    static ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var dummy = new ListNode(0);
        var atual = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                atual.next = list1;
                list1 = list1.next;
            }
            else
            {
                atual.next = list2;
                list2 = list2.next;
            }

            atual = atual.next;
        }

        if (list1 != null)
        {
            atual.next = list1;
        }
        else
        {
            atual.next = list2;
        }

        return dummy.next;
    }
}
