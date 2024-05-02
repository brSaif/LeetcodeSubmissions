using System.Threading;

public class FizzBuzz {
    private int n;
    private Barrier b = new Barrier(4);

    public FizzBuzz(int n) {
        this.n = n;
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz) {
        for(int i = 1; i <= n; ++i){
            if(i % 3 ==0 && i % 5 != 0 ) printFizz();
            b.SignalAndWait();
        }
        
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz) {
        for(int i = 1; i <= n ; ++i){
            if(i  % 5 == 0 && i % 3 != 0) printBuzz();
            b.SignalAndWait();
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz) {
        for(int i = 1 ; i <= n ; ++i){
            if(i % 5 == 0 && i % 3 == 0) printFizzBuzz();
            b.SignalAndWait();
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber) {
        for(int i = 1 ; i <= n ; ++i){
            if(i % 3 != 0 && i % 5 != 0 ) printNumber(i);
            b.SignalAndWait();
        }
    }
}