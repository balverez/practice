import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class SolutionTest {

    @Test
    public void test1() {
        assertThat(new Solution().compress("AAAAaaabbbbbcccc") == "A4a3b5c4");
    }

    @Test
    public void test2() {
        assertThat(new Solution().compress("aabbbbccc") == "a2b4c3");
    }

    @Test
    public void test3() {
        assertThat(new Solution().compress("abc") == "abc");
    }

    @Test
    public void test4() {
        assertThat(new Solution().compress("aabbbcddddeeeeef") == "a2b3cd4e5f");
    }

    @Test
    public void test5() {
        assertThat(new Solution().compress("AABBBBBBBCCDDDDDDaaabbbbbcccc") == "A2B7C2D6a3b5c4");
    }

    @Test
    public void test6() {
        assertThat(new Solution().compress("a") == "a");
    }

    @Test
    public void test7() {
        assertThat(new Solution().compress("") == "");
    }
}
