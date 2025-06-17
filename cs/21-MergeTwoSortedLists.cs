#nullable enable
public class Solution {
    public ListNode? MergeTwoLists(ListNode? a, ListNode? b)
    {
        ListNode? head = null;
        ListNode? tail = null;

        if (a is null && b is null)
        {
            return head;
        }

        if (a is null)
        {
            head = b!;
            b = b!.next;
        }
        else if (b is null)
        {
            head = a!;
            a = a!.next;
        }

        if (a is not null && b is not null)
        {
            if (a.val <= b.val)
            {
                head = a;
                a = a.next;
            }
            else
            {
                head = b;
                b = b.next;
            }
        }

        tail = head;

        while (a is not null || b is not null)
        {
            if (a is null)
            {
                tail!.next = b;
                if (tail!.next == null)
                {
                    break;
                }
                b = b!.next;

                goto move_tail;
            }

            if (b == null)
            {
                tail!.next = a;
                if (tail!.next == null)
                {
                    break;
                }
                a = a.next;
                goto move_tail;
            }

            if (a.val <= b.val)
            {
                tail!.next = a;
                a = a.next;
                goto move_tail;
            }
            else
            {
                tail!.next = b;
                b = b.next;
                goto move_tail;
            }

        move_tail:
            tail = tail!.next;
        }
        return head;
    }
}