namespace Fibonacci;

public class Fibonacci
{
    public int GetIth(int index) {
        int a = 1;
        int b = 1;
        int result = 0;

        if(index <= 0) {
            return 0;
        }

        if(index < 3) {
            return 1;
        }

        for(int i = 3; i <= index; i++) {
            result = a + b;
            b = a;
            a = result;
        }

        return result;
    }
}
