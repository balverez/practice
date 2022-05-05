import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {

    @Test
    public void test1() {
        DoubleLinkListNode head = new DoubleLinkListNode(1);
        head.next = new DoubleLinkListNode(2, head, null);
        head.next.next = new DoubleLinkListNode(3, head.next, null);
        int test = -1;
        
        assertThat(new Solution().insertAtIndex(head, test, 0).data == test);
    }
}
